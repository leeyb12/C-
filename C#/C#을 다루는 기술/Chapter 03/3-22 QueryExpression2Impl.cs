// 투명 구분자를 이용한 쿼리 변환

words.Select(word => new { word, length = word.Length })
     .Where(tmp => tmp.length > 4)
     .OrderBy(tmp => tmp.length)
     .Select(tmp => string.Format("{0}: {1}", tmp.length, tmp.word.ToUpper()));