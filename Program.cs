int menuSelect = 0;

while(menuSelect != 3){
    mainMenu();
    menuSelect = int.Parse(Console.ReadLine());
    if(menuSelect == 1){
        GetFull();
    }
    else if(menuSelect == 2){
        GetPartial();
    }
    else if(menuSelect == 3){
        System.Console.WriteLine("Thank you for using Wagner's Wacky Wiangles. Goodbye.");
    //program ends
    }
    else
    {
        System.Console.WriteLine("Please make a valid selection from 1-3.");
    }
}

static void mainMenu(){
    System.Console.WriteLine("Welcome to Wagner's Wacky Wiangles. Please enter a number according to the selections below.");
    System.Console.WriteLine("Please enter 1 to view a full triangle.");
    System.Console.WriteLine("Please enter 2 to view a partial triangle.");
    System.Console.WriteLine("Please enter 3 to exit the program.");
}

static void GetFull(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);

        int val = number;  
         int i;
         int j;
         int k;  
         for (i = 1; i <= val; i++){  
            
            for (j = 1; j <= val-i; j++){  
               Console.Write("");  
            }  
            
            for (k = 1; k <= i; k++){  
               Console.Write("O ");  
            }  
            Console.WriteLine("");  
         }               
}

static void GetPartial(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);

        int val = number;  
         int i;
         int j;
         int k;  
         for (i = 1; i <= val; i++){  
            
            for (j = 1; j <= val-i; j++){  
               Console.Write("");  
            }  
            
            for (k = 1; k <= i; k++){
                Random rand = new Random();
                int decisionInt = rand.Next(2);  
               
               if(decisionInt == 0){
                Console.Write("O ");
               }
               else if(decisionInt == 1){
                Console.Write("  ");
               }  
            }  
            Console.WriteLine("");  
         }  
}


