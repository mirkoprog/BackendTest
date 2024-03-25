namespace BackendTest.Manager
{
    public class UtilityManager
    {
        public string CategorizeTriangle(int sideA, int sideB, int sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                return "INVALID PARAMS";

            List<int> sides = new List<int> { sideA, sideB, sideC };
            sides.Sort();

            if (sides[0] + sides[1] <= sides[2])
                return "Not a triangle";

            if (sideA == sideB && sideB == sideC)
                return "Equilateral triangle";

            if (sideA == sideB || sideB == sideC || sideA == sideC)
                return "Isosceles triangle";
            
            if (sideA * sideA + sideB * sideB == sideC * sideC ||
                sideA * sideA + sideC * sideC == sideB * sideB ||
                sideB * sideB + sideC * sideC == sideA * sideA)
                return "Right triangle";

            return "Scalene triangle";
        }

        public string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }

        public int GetNthFromEnd(int[] values, int n)
        {
            int index = values.Length - n;
            int result = 0;

            if (index >= 0 && index < values.Length)
            {
                result = values[index];
            }

            return result;
        }
    }
}
