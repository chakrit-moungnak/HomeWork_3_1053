class Program3_2 {
    // ผมไม่รู้วิธีการนำ pop มาใช้ครับ นำมาใช้แล้วโปรแกรมแตกเลย ถ้าอาจารย์อ่านโค้ดของผม ได้โปรดช่วยชี้แนะวิธีผ่านการคอมเม้นตอนบอกคะแนนด้วยนะะครับ
    // ผมลองเก็บส่วนที่นำมาใช้สำหรับฟังก์ชั่น pop เอาไว้นะครับ เผื่อจะช่วยให้อาจารย์ระบุข้อผิดพลาดได้ง่ายขึ้น
    static void Main(string[] args){
        Menu();
        ThorwFruit();
    }

    static void Menu(){
        Console.WriteLine("Please input any fruit or input another key to cancel.");
        Console.WriteLine("1. L for Large fruit.");
        Console.WriteLine("2. M for Medium fruit.");
        Console.WriteLine("3. S for Small fruit.");
        //Console.WriteLine("4. X for rose");
    }

    static void ThorwFruit(){
        Queue<char> fruitlist = new Queue<char>();
        Console.WriteLine("input fruit. ");
        Console.WriteLine("-------------------------------------------------------");

        while (true){
            char Slice;
            char.TryParse(Console.ReadLine(),out Slice);
            if (Slice != 'S' && Slice != 'M' && Slice != 'L'){
                break;
            }
            //else if (Slice == 'X'){
                //fruitlist.Pop(0);
            //} 
            else {
                if (Slice == 'L'){
                    fruitlist.Push('1');
                }
                else if (Slice == 'M'){
                    fruitlist.Push('2');
                }
                else if (Slice == 'S'){
                    fruitlist.Push('3');
                }
            }
        }
        for (int i = 0; i < fruitlist.GetLength(); i++){
                if(fruitlist.Get(i) == '1'){
                    fruitlist.Push('2');
                    fruitlist.Push('2');
                }
                else if (fruitlist.Get(i) == '2'){
                    fruitlist.Push('3');
                    fruitlist.Push('3');
                    fruitlist.Push('3');
                }
            }
        Console.WriteLine("");
        Console.WriteLine("Total fruit. ");
        Console.WriteLine("-------------------------------------------------------");
        for (int i = 0; i < fruitlist.GetLength(); i++){
                    Console.Write(fruitlist.Get(i));
        }
    }
}