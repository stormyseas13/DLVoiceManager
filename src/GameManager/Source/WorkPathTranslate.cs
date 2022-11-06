using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks; 

namespace GameManager {
    public class WorkPathTranslate {
        public DirectoryInfo directory;
        public Task task = null;
        GoogleTranslate translator = new GoogleTranslate("ja", "en");
        // Translates all files in a path
        public void FilePathTranslate() {
            string[] translatableExtensions = { ".mp3", ".opus", ".oga", ".flac", ".wav", ".ogg", ".aac", ".opus", ".m4a", ".mp4" };
            string[] charsToRemove = { "\"", "?", "\\", "/", "<", ">", "|", "*", ":" };

            foreach (var f in directory.EnumerateFiles("*", SearchOption.AllDirectories)) {
                string fName = f.Name;
                string fFullName = f.FullName;

                string fParentPath = System.IO.Directory.GetParent(fFullName).ToString();
                string fNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fName);
                string fNameExtension = System.IO.Path.GetExtension(fName);
            
                if (!translatableExtensions.Any(fNameExtension.Contains)) {
                    continue;
                }

                var translatorTask1 = Task.Factory.StartNew(() => translator.TranslateString(fNameWithoutExtension));
                var translated_fName = translatorTask1.Result + fNameExtension;

                foreach (var c in charsToRemove) {
                    translated_fName = translated_fName.Replace(c, string.Empty);
                }

                task = translatorTask1.ContinueWith(_ => {
                    try {
                        if (fName !=  translated_fName && translated_fName != null && translated_fName.Length > 0) {
                            string translated_dFullName = System.IO.Path.Combine(fParentPath, translated_fName);
                            Directory.Move(fFullName, translated_dFullName);
                        }

                    }
                    catch (Exception e) {
                        Logger.LogExceptionIfDebugging(e);
                    }

                }, TaskContinuationOptions.OnlyOnRanToCompletion);
            }
        }
        // Translates all directiories in a path
        public void DirPathTranslate() {

            foreach (var d in directory.EnumerateDirectories("*", SearchOption.AllDirectories)) {
                string dName = d.Name;
                string dFullName = d.FullName;
                string dParentPath = System.IO.Directory.GetParent(dFullName).ToString();
                Regex RECodePattern = new Regex(@"(RE)\d\d\d\d\d\d", RegexOptions.IgnoreCase | RegexOptions.Compiled);


                var translatorTask2 = Task.Factory.StartNew(() => translator.TranslateString(dName));
                var translated_dName = translatorTask2.Result;

                foreach (char c in System.IO.Path.GetInvalidPathChars()) {
                    translated_dName = translated_dName.Replace(c, ' ');
                }
                if (RECodePattern.Match(translated_dName).Success) {
                    Console.WriteLine("Changed!");
                    continue;
                }
                task = translatorTask2.ContinueWith(_ => {
                    try {
                        if (dName !=  translated_dName && translated_dName != null && translated_dName.Length > 0) {
                            string translated_dFullName = System.IO.Path.Combine(dParentPath, translated_dName);
                            Directory.Move(dFullName, translated_dFullName);
                        }

                    }
                    catch (Exception e) {
                        Logger.LogExceptionIfDebugging(e);
                    }

                }, TaskContinuationOptions.OnlyOnRanToCompletion);
            }
        }
        // Translates mainPath in a path
        public void MainPathTranslate() {
            string dirFullName = directory.FullName;
            string dirName = directory.Name;
            string parentPath = System.IO.Directory.GetParent(dirFullName).ToString();

            var translatorTask3 = Task.Factory.StartNew(() => translator.TranslateString(dirName));
            var translated_dirName = translatorTask3.Result;
            task = translatorTask3.ContinueWith(_ => {
                try {
                    if (dirName !=  translated_dirName && translated_dirName != null && translated_dirName.Length > 0) {
                        string translated_dFullName = System.IO.Path.Combine(parentPath, translated_dirName);
                        Directory.Move(dirFullName, translated_dFullName);
                    }

                }
                catch (Exception e) {
                    Logger.LogExceptionIfDebugging(e);
                }

            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }

    }
}
