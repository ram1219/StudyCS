using System;
using System.Globalization;
using static System.Console;

namespace SearchString
{
	class Program
	{
		static void Main(string[] args)
		{
			string greeting = "Good Morning";

			// ""앞에 $표시를 한 후 {}안에 사용하고 싶은 값을 바로 삽입이 가능하다.
			// IndexOf() -> 찾는 값이 없을 경우 -1 return. 
			WriteLine($"IndexOf 'Good' : {greeting.IndexOf("Good")}");          // 0
			WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");  // 0

			WriteLine($"Indexof 'n' : {greeting.IndexOf('n')}");                // 8  -> 앞에서 부터 탐색을 하므로 8번째 n의 위치를 반환
			WriteLine($"LastIndexof 'n' : {greeting.LastIndexOf('n')}");        // 10 -> 뒤에서 부터 탐색을 하므로 10번째의 n의 위치를 반환

			// 찾는 문자열이 Good으로 시작하면 true return
			WriteLine($"StartWith 'Good' {greeting.StartsWith("Good")}");       // true

			// Good을 포함하고 있는 경우 true return
			WriteLine($"Contains 'Good' : {greeting.Contains("Good")}");

			// Morning을 Evening으로 변경
			WriteLine($"Replace 'Morning' to 'Evening : " + $"{greeting.Replace("Morning", "Evening")}");

			if (greeting.Contains("Morning"))
				WriteLine($"{greeting.Replace("Morning", "Evening")}");
			else
				WriteLine($"{greeting.Replace("Evening", "Morning")}");

			// 문자열의 모든 문자를 소문자로 변환
			WriteLine($"ToLower : {greeting.ToLower()}");
			// 문자열의 모든 문자를 대문자로 변환
			WriteLine($"ToUpper : {greeting.ToUpper()}");

			// 원하는 부분에 원하는 문자열 삽입
			WriteLine($"Insert : {greeting.Insert(greeting.IndexOf("Morning") - 1, " Very")}");

			// I don't Love You 문자열의 2번째부터 6번째까지의 문자 삭제
			WriteLine($"Remove : '{"I don't Love You".Remove(2, 6)}'");

			// 문자열의 앞, 뒤 모든 공백 제거
			WriteLine($"Trim : '{" No Space ".Trim()}'");
			// 문자열 앞의 공백 제거
			WriteLine($"Trim : '{" No Space ".TrimStart()}'");
			// 문자열 뒤의 공백 제거
			WriteLine($"Trim : '{" No Space ".TrimEnd()}'");

			string codes = "MSFT,GOOG,AMZN,AAPI,RHT";

			// codes 문자열을 (,)를 기준으로 분할하여 result라는 배열로 생성
			var result = codes.Split(',');
			foreach (var item in result)
				WriteLine($"each itme '{item.Trim()}'");

			// substring -> 문자열의 일정 부분을 잘라낸다. (자를 시작지점, 길이)
			// 길이 지정을 하지 않으면 마지막 부분까지 다 잘라낸다.
			WriteLine($"substring : {greeting.Substring(0, 4)}");       // Good
			WriteLine($"substring : {greeting.Substring(5)}");          // Morning

			WriteLine(string.Format("{0}DEF", "ABC"));                  // ABC
			WriteLine(string.Format("{0, -10}DEF", "ABC"));             // ABC			DEF
			WriteLine(string.Format("{0, 10}DEF", "ABC"));              //			 ABCDEF

			// 날짜 형식 표현
			DateTime dt = DateTime.Now;
			WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}", dt));    // 한국식
			WriteLine(string.Format("{0:d/M/yyyy HH:mm:ss}", dt));      // 미국식 --> 그러나 위와 같이 날짜가 -로 구분되어 출력됨
			WriteLine(string.Format($"{dt:y yy yyy yyyy}"));
			WriteLine(string.Format("{0:M MM MMM MMMM}", dt));

			// ToString은 국가, 문화권 형식도 추가하여 출력가능하다.
			WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("ko-KR")));
			WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));      // 미국식 형식인 /로 구분되어 출력

			// 금액 형식 표현
			decimal mValue = 27000000;
			WriteLine(string.Format("price : {0:C}", mValue));
			WriteLine(string.Format($"price : {mValue:C}"));

			WriteLine(mValue.ToString("C", new CultureInfo("ko-KR")));  // 원 형식으로 출력
			WriteLine(mValue.ToString("C", new CultureInfo("en-US")));  // 달려 형식으로 출력
			WriteLine(mValue.ToString("C", new CultureInfo("ja-JP")));  // 엔화 형식으로 출력
		}
	}
}
