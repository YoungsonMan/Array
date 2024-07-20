/**************************************************************************
 * 배열 과제
 * 최연승
 * 과제 1. 고정 배열 생성 및 출력
 * 과제 2. 배열의 요소 변경 및 출력
 **************************************************************************/

namespace ArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제1
            /* 과제 1. 고정 배열 생성 및 출력 */
            // 4개의 정수를 담을 수 있는 배열을 하나 생성후,
            // 사용자에게 순서대로 값을 입력받아 순서대로 배열에 담기.
            // 해당 문을 foreach로 출력하기.

            // int 4개를 담을 배열을선언
            int[] array = new int[4];
            // "1번 요소를 입력하여 주십시오." 출력후 입력받기
            // 나머지 번호도 마찬가지로 입력
            Console.WriteLine("첫번째 요소를 입력하여 주십시오");
            for (int number = 0; number < array.Length; number++)
            {
                array[number] = Convert.ToInt32(Console.ReadLine());
                if (number < 3)
                {
                    Console.WriteLine("다음 숫자");
                }
            }
            // 입력된 요소는 다음과 같습니다. 
            Console.WriteLine("입력된 요소는 다음과 같습니다.");

            foreach (int number in array)
            {
                Console.Write(number + "\t");
            }

            #endregion

            Console.WriteLine("\n\n");
            Console.WriteLine("============ 과제 2 =============\n");
            #region 과제2
            /* 배열의 요소 변경 및 출력 */
            // 4x4 16개의 정수를 담을 수 있는 2차원 배열을 만든 후,
            // int형 2차원 배열을 선언
            int[,] arr = new int[4, 4];
            int triplet = 1;
            // 반복문을 이용하여 3의 배수들로 채워 넣는다. 
            /*
             * [ 0 , 1 , 2 , 3 ]
             * [ 4 , 5 , 6 , 7 ]
             * [ 8 , 9 , 10, 11]
             * [ 12, 13, 14, 15]
             */
            for (int i = 0; i < arr.GetLength(0); i++)  // i = column 행
            {

                for (int j = 0; j < arr.GetLength(1); j++)  // j = row 열
                {
                    // 반복문을 통하여 순서대로 3의 배수들로 채워넣음
                    arr[i, j] = triplet * 3;
                    triplet++;
                    Console.Write($"{arr[i, j]}\t");
                    // 4 x 4 의 형태로 들어있는 숫자들을 출력.
                    // 4개가 채워지면 다음 줄로 넘어가게하기.
                    if ((j + 1) % 4 == 0)
                    {
                        Console.WriteLine();
                    }

                }
            }
            Console.WriteLine("============ 2nd Part =============");
            Console.WriteLine(" 2행3열 요소와 3행2열 요소 바꾸기 ");
            // 그 후 2행3열 요소와 3행2열 요소를 바꾼 후 출력해보자
            // 2행 3열 요소와 3행 2열 요소를 바꾼다 [ ]는 0부터시작
            // 2행 3열 => [1,2] = 21
            // 3행 2열 => [2,1] = 30
            // [1,2] <--> [2,1] = 21 => 30
            /* *********************************
             * 윗내용 테스트
             * int change;
             * change = arr[1, 2] = arr[2, 1];
             * Console.Write(change);
             **************************************/
            int change;
            change = arr[1, 2];         // 저장소 마련
            arr[1, 2] = arr[2, 1];      // [1, 2]를 [2, 1]로 대체 
            arr[2, 1] = change;         // 비어버린 [2, 1]를 저장소에있던 걸로 대체
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
                if ((i) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }

            // 늦어서 죄송합니다!
            // 최대한 제 힘으로 해보려다보니 생각 보다 더 오래걸렸습니다

            #endregion
        }
    }
}



