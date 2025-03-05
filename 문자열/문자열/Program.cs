namespace 문자열
{
    // 원하는 문자열 찾기 -> https://school.programmers.co.kr/learn/courses/30/lessons/181878
    internal class Program
    {
        public int solution(string myString, string pat)
        {
            int answer = 0;

            if(pat.Length > myString.Length)
            {
                return answer;
            }

            myString = myString.ToLower();
            pat = pat.ToLower();

            if(myString.Contains(pat))
            {
                answer = 1;
            }

            return answer;
            // 답을 한줄로 적어보자면
            // return myString.ToLower().Contains(pat.ToLower()) ? 1 : 0;
        }

        static void Main(string[] args)
        {

        }
    }
}
