namespace CalculoGanhoCapital.Util
{
    public class JsonConvert
    {
        public static List<string> Operations(string jsonInput)
        {
            var lstInput = jsonInput.Split(']').ToList();

            for (int i = 0; i < lstInput.Count - 1; i++)
            {
                string input = lstInput[i];
                input = input.Insert(input.Length, "]");
                lstInput[i] = input;
            }

            lstInput.RemoveAt(lstInput.Count - 1);

            return lstInput;
        }
    }
}
