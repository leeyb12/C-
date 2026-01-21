// 필터, 정렬, 프로젝션을 포함하는 쿼리 표현식 소개

IEnumerable<string> query = from word in words
                            where word.Length > 4
                            orderby word
                            select word.ToUpper();