class Program3_1 {
    // ผมไม่รู้วิธีการทำให้เวลาใส่ R ตัวแรกแล้วโปรแกรมไม่เจ๊ง ถ้าอาจารย์อ่านโค้ดของผม ได้โปรดช่วยชี้แนะวิธีผ่านการคอมเม้นตอนบอกคะแนนด้วยนะะครับ
    static void Main(string[] args){
        Menu();
        ThorwFlower();
    }

    static void Menu(){
        Console.WriteLine("Please input any flower or input another key to cancel.");
        Console.WriteLine("1. J for jasmine");
        Console.WriteLine("2. G for amaranth");
        Console.WriteLine("3. O for orchid");
        Console.WriteLine("4. R for rose");
        Console.WriteLine("5. X for remove");
    }

    static void ThorwFlower(){
        CircularLinkedList<char> flowerlist = new CircularLinkedList<char>();
        Console.WriteLine("input flower. ");
        Console.WriteLine("-------------------------------------------------------");

        while (true){
            flowerlist.Add(Char.Parse(Console.ReadLine()));
            if(flowerlist.Get(flowerlist.GetLength()-1) != 'J' && flowerlist.Get(flowerlist.GetLength()-1) != 'G' && flowerlist.Get(flowerlist.GetLength()-1) != 'O'
            && flowerlist.Get(flowerlist.GetLength()-1) != 'R' && flowerlist.Get(flowerlist.GetLength()-1) != 'X'){
                flowerlist.Remove(flowerlist.GetLength()-1);

                Console.WriteLine("");
                Console.WriteLine("Total flower. ");
                Console.WriteLine("-------------------------------------------------------");
                for(int i = 0; i < flowerlist.GetLength(); i++){
                    Console.WriteLine(flowerlist.Get(i));
                }
                break;
            }
            else if (flowerlist.Get(flowerlist.GetLength()-1) == 'R'){
                if (flowerlist.Get(flowerlist.GetLength()-2) == flowerlist.Get(0)){
                    Console.WriteLine("Invalid pattern");
                    flowerlist.Remove(flowerlist.GetLength()-1);
                }
            }
            
            else if(flowerlist.GetLength() >= 4){
            if(flowerlist.Get(flowerlist.GetLength()-1) == 'G'){
                if (flowerlist.Get(flowerlist.GetLength()-2) == 'G' && flowerlist.Get(0) == 'G' && flowerlist.Get(flowerlist.GetLength()-3) == 'G'){
                    Console.WriteLine("Invalid pattern");
                    flowerlist.Remove(flowerlist.GetLength()-1);
                }
                else if (flowerlist.Get(flowerlist.GetLength()-2) == 'G'  && flowerlist.Get(flowerlist.GetLength()-3) == 'G' && flowerlist.Get(flowerlist.GetLength()-4) == 'G'){
                    Console.WriteLine("Invalid pattern");
                    flowerlist.Remove(flowerlist.GetLength()-1);
                }
            }
            }
            if(flowerlist.Get(flowerlist.GetLength()-1) == 'X'){
                flowerlist.Remove(flowerlist.GetLength() - 1);
                flowerlist.Remove(flowerlist.GetLength() - 1);
            }
        }
    }
}

