namespace Medium
{
    // 크기가 작은 부분 문자열 -> https://school.programmers.co.kr/learn/courses/30/lessons/147355
    internal class Program
    {
        public int solution(string t, string p)
        {
            int answer = 0;
            if(p.Length < 1 || p.Length > 18)
            {
                return 0;
            }

            if(t.Length < p.Length)
            {
                return 0;
            }

            // 이 부분은 제한사항 중에
            // t와 p는 숫자로만 이루어진 문자열이며, 0으로 시작하지 않습니다.
            // 를 신경써서 작성했던 부분인데 
            // 이건 그냥 데이터에 대한 사전 조건으로 보장되어 있는 것들이라고 판단하면 된다.
            // 이걸 코드로 또 검증할 필요는 없다는 것
            // 근데 이거 빼도 똑같이 런타임 에러남 ㅋㅋ 점수 똑같더라

            //if (t[0] == '0' || p[0] == '0')
            //{
            //    return 0;
            //}

            //foreach (char c in t)
            //{
            //    if (!char.IsDigit(c)) // (c < '0' || c > '9') 이것도 런타임 에러남
            //    {
            //        return 0;
            //    }
            //}

            //foreach (char c in p)
            //{
            //    if (!char.IsDigit(c)) // (c < '0' || c > '9') 이것도 런타임 에러남
            //    {
            //        return 0;
            //    }
            //}

            // int의 범위는 21억이므로 long을 사용하는게 좋다.
            long num2 = long.Parse(p);

            for (int i = 0; i <= t.Length - p.Length; i++)
            {
                string part = t.Substring(i, p.Length);

                long num1 = long.Parse(part);
                // int num2 = int.Parse(p); 이건 반복문 밖에서 한 번만 해줘도 된다. ★★★★ 이걸 여기서 해준게 가장 큰 문제였다.

                if (num1 <= num2)
                {
                    answer++;
                    // part.Replace(part, ""); 이건 처음에 part에다가 append 쓰려고 했는데 문자열에는 append 못쓴다고 해서 다른걸로 변경했으니 필요가 없어짐
                }
            }

            return answer;
        }

        /*다른사람 풀이
         public class Solution 
         {
            public int solution(string t, string p) 
            {
                int answer = 0;
                int pLen = p.Length;
                long pLong = Convert.ToInt64(p);
                for(int i=0; i<t.Length-pLen+1; i++)
                {
                    long tLong = Convert.ToInt64(t.Substring(i, pLen));

                    if(tLong <= pLong)
                    {
                        answer++;
                    }
                }
                return answer;
            }
         }
         */

        static void Main(string[] args)
        {
            
        }
    }
}
