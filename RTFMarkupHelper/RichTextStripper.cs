﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace RTFMarkupHelper {
    /// <summary>
    /// Rich Text Stripper
    /// https://chrisbenard.net/2014/08/20/extract-text-from-rtf-in-c-net/
    /// </summary>
    /// <remarks>
    /// Translated from Python located at:
    /// http://stackoverflow.com/a/188877/448
    /// </remarks>
    public class RichTextStripper {
        private class StackEntry {
            public int NumberOfCharactersToSkip { get; set; }
            public bool Ignorable { get; set; }

            public StackEntry(int numberOfCharactersToSkip, bool ignorable) {
                NumberOfCharactersToSkip = numberOfCharactersToSkip;
                Ignorable = ignorable;
            }
        }

        private static readonly Regex _rtfRegex = new Regex(@"\\([a-z]{1,32})(-?\d{1,10})?[ ]?|\\'([0-9a-f]{2})|\\([^a-z])|([{}])|[\r\n]+|(.)", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        private static readonly List<string> destinations = new List<string>
        {
        "aftncn","aftnsep","aftnsepc","annotation","atnauthor","atndate","atnicn","atnid",
        "atnparent","atnref","atntime","atrfend","atrfstart","author","background",
        "bkmkend","bkmkstart","blipuid","buptim","category","colorschememapping",
        "colortbl","comment","company","creatim","datafield","datastore","defchp","defpap",
        "do","doccomm","docvar","dptxbxtext","ebcend","ebcstart","factoidname","falt",
        "fchars","ffdeftext","ffentrymcr","ffexitmcr","ffformat","ffhelptext","ffl",
        "ffname","ffstattext","field","file","filetbl","fldinst","fldrslt","fldtype",
        "fname","fontemb","fontfile","fonttbl","footer","footerf","footerl","footerr",
        "footnote","formfield","ftncn","ftnsep","ftnsepc","g","generator","gridtbl",
        "header","headerf","headerl","headerr","hl","hlfr","hlinkbase","hlloc","hlsrc",
        "hsv","htmltag","info","keycode","keywords","latentstyles","lchars","levelnumbers",
        "leveltext","lfolevel","linkval","list","listlevel","listname","listoverride",
        "listoverridetable","listpicture","liststylename","listtable","listtext",
        "lsdlockedexcept","macc","maccPr","mailmerge","maln","malnScr","manager","margPr",
        "mbar","mbarPr","mbaseJc","mbegChr","mborderBox","mborderBoxPr","mbox","mboxPr",
        "mchr","mcount","mctrlPr","md","mdeg","mdegHide","mden","mdiff","mdPr","me",
        "mendChr","meqArr","meqArrPr","mf","mfName","mfPr","mfunc","mfuncPr","mgroupChr",
        "mgroupChrPr","mgrow","mhideBot","mhideLeft","mhideRight","mhideTop","mhtmltag",
        "mlim","mlimloc","mlimlow","mlimlowPr","mlimupp","mlimuppPr","mm","mmaddfieldname",
        "mmath","mmathPict","mmathPr","mmaxdist","mmc","mmcJc","mmconnectstr",
        "mmconnectstrdata","mmcPr","mmcs","mmdatasource","mmheadersource","mmmailsubject",
        "mmodso","mmodsofilter","mmodsofldmpdata","mmodsomappedname","mmodsoname",
        "mmodsorecipdata","mmodsosort","mmodsosrc","mmodsotable","mmodsoudl",
        "mmodsoudldata","mmodsouniquetag","mmPr","mmquery","mmr","mnary","mnaryPr",
        "mnoBreak","mnum","mobjDist","moMath","moMathPara","moMathParaPr","mopEmu",
        "mphant","mphantPr","mplcHide","mpos","mr","mrad","mradPr","mrPr","msepChr",
        "mshow","mshp","msPre","msPrePr","msSub","msSubPr","msSubSup","msSubSupPr","msSup",
        "msSupPr","mstrikeBLTR","mstrikeH","mstrikeTLBR","mstrikeV","msub","msubHide",
        "msup","msupHide","mtransp","mtype","mvertJc","mvfmf","mvfml","mvtof","mvtol",
        "mzeroAsc","mzeroDesc","mzeroWid","nesttableprops","nextfile","nonesttables",
        "objalias","objclass","objdata","object","objname","objsect","objtime","oldcprops",
        "oldpprops","oldsprops","oldtprops","oleclsid","operator","panose","password",
        "passwordhash","pgp","pgptbl","picprop","pict","pn","pnseclvl","pntext","pntxta",
        "pntxtb","printim","private","propname","protend","protstart","protusertbl","pxe",
        "result","revtbl","revtim","rsidtbl","rxe","shp","shpgrp","shpinst",
        "shppict","shprslt","shptxt","sn","sp","staticval","stylesheet","subject","sv",
        "svb","tc","template","themedata","title","txe","ud","upr","userprops",
        "wgrffmtfilter","windowcaption","writereservation","writereservhash","xe","xform",
        "xmlattrname","xmlattrvalue","xmlclose","xmlname","xmlnstbl",
        "xmlopen"
    };

        private static readonly Dictionary<string, string> specialCharacters = new Dictionary<string, string>
        {
        { "par", "\n" },
        { "sect", "\n\n" },
        { "page", "\n\n" },
        { "line", "\n" },
        { "tab", "\t" },
        { "emdash", "\u2014" },
        { "endash", "\u2013" },
        { "emspace", "\u2003" },
        { "enspace", "\u2002" },
        { "qmspace", "\u2005" },
        { "bullet", "\u2022" },
        { "lquote", "\u2018" },
        { "rquote", "\u2019" },
        { "ldblquote", "\u201C" },
        { "rdblquote", "\u201D" },
    };
        /// <summary>
        /// Strip RTF Tags from RTF Text
        /// </summary>
        /// <param name="inputRtf">RTF formatted text</param>
        /// <returns>Plain text from RTF</returns>
        public string StripRichTextFormat(string inputRtf) {
            if (inputRtf == null) {
                return null;
            }

            string returnString;

            var stack = new Stack<StackEntry>();
            bool ignorable = false;              // Whether this group (and all inside it) are "ignorable".
            int ucskip = 1;                      // Number of ASCII characters to skip after a unicode character.
            int curskip = 0;                     // Number of ASCII characters left to skip
            var outList = new List<string>();    // Output buffer.

            MatchCollection matches = _rtfRegex.Matches(inputRtf);

            if (matches.Count > 0) {
                foreach (Match match in matches) {
                    string word = match.Groups[1].Value;
                    string arg = match.Groups[2].Value;
                    string hex = match.Groups[3].Value;
                    string character = match.Groups[4].Value;
                    string brace = match.Groups[5].Value;
                    string tchar = match.Groups[6].Value;

                    if (!String.IsNullOrEmpty(brace)) {
                        curskip = 0;
                        if (brace == "{") {
                            // Push state
                            stack.Push(new StackEntry(ucskip, ignorable));
                        } else if (brace == "}") {
                            // Pop state
                            StackEntry entry = stack.Pop();
                            ucskip = entry.NumberOfCharactersToSkip;
                            ignorable = entry.Ignorable;
                        }
                    } else if (!String.IsNullOrEmpty(character)) // \x (not a letter)
                      {
                        curskip = 0;
                        if (character == "~") {
                            if (!ignorable) {
                                outList.Add("\xA0");
                            }
                        } else if ("{}\\".Contains(character)) {
                            if (!ignorable) {
                                outList.Add(character);
                            }
                        } else if (character == "*") {
                            ignorable = true;
                        }
                    } else if (!String.IsNullOrEmpty(word)) // \foo
                      {
                        curskip = 0;
                        if (destinations.Contains(word)) {
                            ignorable = true;
                        } else if (ignorable) {
                        } else if (specialCharacters.ContainsKey(word)) {
                            outList.Add(specialCharacters[word]);
                        } else if (word == "uc") {
                            ucskip = Int32.Parse(arg);
                        } else if (word == "u") {
                            int c = Int32.Parse(arg);
                            if (c < 0) {
                                c += 0x10000;
                            }
                            outList.Add(Char.ConvertFromUtf32(c));
                            curskip = ucskip;
                        }
                    } else if (!String.IsNullOrEmpty(hex)) // \'xx
                      {
                        if (curskip > 0) {
                            curskip -= 1;
                        } else if (!ignorable) {
                            int c = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                            outList.Add(Char.ConvertFromUtf32(c));
                        }
                    } else if (!String.IsNullOrEmpty(tchar)) {
                        if (curskip > 0) {
                            curskip -= 1;
                        } else if (!ignorable) {
                            outList.Add(tchar);
                        }
                    }
                }
            } else {
                // Didn't match the regex
                returnString = inputRtf;
            }

            returnString = String.Join(String.Empty, outList.ToArray());

            // MakeStringUnicodeCompatible(ref returnString);

            return returnString;
        }

        public static void MakeStringUnicodeCompatible(ref string stringData) {
            int length = 0;
            while (length < stringData.Length) {
                char ch = stringData[length];
                ushort code = Convert.ToUInt16(ch);

                if (code > 127) {
                    // string str = String.Format(@"\u{0}" + "  ", code);
                    string str = String.Format(@"\u{0}" + 3f, code);
                    stringData = stringData.Insert(length + 1, str);
                    stringData = stringData.Remove(length, 1);
                    length += str.Length;
                    continue;
                } else {
                    if (ch == '{' || ch == '}' || ch == '\\') {
                        stringData = stringData.Insert(length, @"\");
                        length++;
                    }
                }
                length++;
            }

            // cemerson 20160504055201: fix extra spaces created sometimes like:
            // \u132   \u3ad    \u3434
            stringData = stringData.Replace(@"  \\u", @" \\u");
            // stringData = stringData.Replace("  ", String.Empty);

            // cemerson 20160427124322: added line to fix superscripted registration marks
            // Æ (Registration Mark)            
            stringData = stringData.Replace(@"\\super\\'ae\\nosupersub", @"\\'ae");
            stringData = stringData.Replace(@"Æ", @"\\'ae");
            stringData = stringData.Replace(@"\u174", @"\\'ae");
            stringData = stringData.Replace(@"\\'ae", @"\super\'ae\nosupersub");
            // © (Copyright Mark)            
            stringData = stringData.Replace(@"\\super\\'a9\\nosupersub", @"\\'a9");
            stringData = stringData.Replace(@"©", @"\\'a9");
            stringData = stringData.Replace(@"\u169", @"\\'a9");
            stringData = stringData.Replace(@"\\'a9", @"\super\'a9\nosupersub");
        }

    }
}
