﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kanji.DatabaseMaker
{
    /// <summary>
    /// Contains path to the external resources used by the program.
    /// </summary>
    class PathHelper
    {
        public static readonly string ResourcesBasePath = "Resources";
        public static readonly string JmDictPath = Path.Combine(ResourcesBasePath, "JMdict.xml");
        public static readonly string KanjiDic2Path = Path.Combine(ResourcesBasePath, "kanjidic2.xml");
        public static readonly string KradFilePath = Path.Combine(ResourcesBasePath, "kradfile");
        public static readonly string KradFile2Path = Path.Combine(ResourcesBasePath, "kradfile2");
        public static readonly string TopVocabularyFrequencyPath = Path.Combine(ResourcesBasePath, "TopVocabularyFrequency.txt");
        public static readonly string JmDictFuriganaPath = Path.Combine(ResourcesBasePath, "JmdictFurigana.txt");
        public static readonly string JlptKanjiListPath = Path.Combine(ResourcesBasePath, "JLPTKanjiList.txt");
        public static readonly string JlptVocabListPath = Path.Combine(ResourcesBasePath, "JLPTVocabList.txt");
        public static readonly string WordUsagePath = Path.Combine(ResourcesBasePath, "WordUsage.txt");
        public static readonly string KanjiUsagePath = Path.Combine(ResourcesBasePath, "KanjiUsage.txt");
        public static readonly string SvgZipPath = Path.Combine(ResourcesBasePath, "svgs.zip");
        public static readonly string WaniKaniKanjiListPath = Path.Combine(ResourcesBasePath, "WaniKaniKanjiList.txt");
        public static readonly string WaniKaniVocabListPath = Path.Combine(ResourcesBasePath, "WaniKaniVocabList.txt");
    }
}
