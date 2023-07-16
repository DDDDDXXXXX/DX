namespace Work {
    public class StartWork {
        public string StartIf() {
            Console.WriteLine("輸入數字比大小");
            int InputNum = int.Parse(Console.ReadLine());
            int InputNum2 = int.Parse(Console.ReadLine());
            int num = InputNum;
            int num2 = InputNum2;
            if (num > num2) {
                string x = $"{num}比較大";
                if (num > 10) {
                    x += "又大於10";
                }
                return x;
            }
            return $"{num}not大";
        }
        public string StartSwitch() {
            Console.WriteLine("輸入A~C任一單字");
            string NowSay = (Console.ReadLine());
            switch (NowSay) {
                case "A":
                return "APPLE";
                case "B":
                return "BANANA";
                case "C":
                return "WATERMELON";
                default:
                return "COOL";
            }
        }
        public void StartLoop(int[] num) {
            int x = 0;
            Console.WriteLine("迴圈for");
            for (int i = 0; i < num.Length; i++) {
                x += num[i];
                Console.WriteLine(x);
            }
        }
        public void StartLoopEach(string[] ReadySay) {
            Console.WriteLine("對話");
            foreach (string NowSay in ReadySay) {
                Console.WriteLine(NowSay);
            }
        }
    }
    public class progoam {
        static void Main() {
            StartWork print = new StartWork();
            int[] array = new int[] { 1, 3, 5, 7, 9 };
            string[] say = new string[] { "HI", "YO", "ARE YOU GOOD?", "YES" };
            Console.WriteLine(print.StartIf());
            Console.WriteLine(print.StartSwitch());
            print.StartLoop(array);
            print.StartLoopEach(say);





            Console.ReadKey();
        }
    }
}


