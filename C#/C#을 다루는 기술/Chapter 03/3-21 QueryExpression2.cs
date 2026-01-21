// let을 이용하여 새로운 범위 변수 지정

from word in words
let length = word.length
where length > 4
orderby length
select string.Format("{0}: {1}", length, word.ToUpper());