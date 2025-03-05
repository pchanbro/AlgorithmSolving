namespace high
{
    // 문자열 나누기 -> https://school.programmers.co.kr/learn/courses/30/lessons/140108?language=csharp
    internal class Program
    {
        // 1. 문자열을 받는다.
        // 2. 문자열의 길이 파악
        // 조건1. 길이는 1 ~ 10000 제한
        // 조건2.문자열의 각 문자는 소문자로 제한
        // 반복
        // 5. 시작 문자 개수 갱신
        // 6. 시작 문자와 다른 문자 개수 갱신
        // 7. 시작 문자와 다른 문자 개수가 같거나 더 이상 읽을 글자가 없다면 문자열 분리 후 answer + 1
        public int solution(string s)
        {
            int answer = 0;
            if (s.Length < 1 || s.Length > 10000)
            {
                return answer;
            }

            foreach (char c in s)
            {
                if (!char.IsLower(c)) // if (c < 'a' || c > 'z'), 소문자 알파벳('a'-'z')은 아스키 코드로 97부터 122까지의 값을 가집니다.
                {
                    return answer;
                }
            }

            while (s.Length > 0)
            {
                char start = s[0];
                int startCharNum = 0;
                int anotherCharNum = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == start)
                        startCharNum++;
                    else
                        anotherCharNum++;

                    if (startCharNum == anotherCharNum)
                    {
                        answer++;
                        s = s.Substring(i + 1); // s = s.Remove(0, i + 1); 해도 좋다.
                        break;
                    }
                }

                // 더 이상 읽을 글자가 없는 경우
                if (startCharNum != anotherCharNum)
                {
                    answer++;
                    break;
                }
            }

            return answer;
        }

        static void Main(string[] args)
        {

        }
    }
}
