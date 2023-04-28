

public class RecipeApp
{
static void Main (string  [] args)

    {

String Answer; 
bool ChangedQuantity = false; 

int numOFIngredients;

 string[,] Ingredients = new string[10,4];


Console.WriteLine("                              <Recipe>                           ");
Console.WriteLine("numbers of ingredients");
numOFIngredients = int.Parse(Console.ReadLine());



  for (int i = 0; i < numOFIngredients; i++) 
        { 
Console.WriteLine("Ingredient "+(1+i).ToString());

Console.WriteLine("Name of ingredient");
Ingredients[i,0] =  Console.ReadLine();

Console.WriteLine("Quantity of ingredient");
Ingredients[i,1] = Console.ReadLine();

Console.WriteLine("Unit of measurement for ingredients");
Ingredients[i,2] = Console.ReadLine();
Console.WriteLine("\n\n");

      }

        




 int numOfSteps;
 string[,] Steps = new string[15,1];

Console.WriteLine("                              <Steps>                           ");
Console.WriteLine("number of Steps ");
        
 numOfSteps = int.Parse(Console.ReadLine());


  for (int i = 0; i < numOfSteps; i++) 
        { 
Console.WriteLine("Step "+(1+i).ToString());

Console.WriteLine("Description of Step");
Steps[i,0] =  Console.ReadLine();
Console.WriteLine("\n\n");

        }



Console.WriteLine("\n"+"\n"+"\n");
Console.WriteLine("\n"+"\n"+"\n");


Console.WriteLine("///////////////////////////////////////////////////////////////");
Console.WriteLine("Menu");
Console.WriteLine("///////////////////////////////////////////////////////////////");
Console.WriteLine("Recipe preview                     Enter(1)");
Console.WriteLine("Scale ingredients quantity         Enter(2)");
Console.WriteLine("Reset to original value            Enter(3)");
Console.WriteLine("Clear Data                         Enter(4)");
Console.WriteLine("///////////////////////////////////////////////////////////////");
Console.WriteLine("Select");
Answer = Console.ReadLine();



int whileNum = 1;

while ( whileNum < 2 ) { 

if  (Answer == "1" && ChangedQuantity == false)
        {

Console.WriteLine("\n"+"\n"+"\n");
Console.WriteLine("\n"+"\n"+"\n");

Console.WriteLine("------------------- Recipe preview ---------------------------");
Console.WriteLine("Number of ingredients: " +  numOFIngredients.ToString());

  for (int i = 0; i < numOFIngredients; i++) 
        { 
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Ingredient "+(1+i).ToString());
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Name of ingredient");
Console.WriteLine(Ingredients[i,0]);

Console.WriteLine("Quantity of ingredient");
Console.WriteLine(Ingredients[i,1]); 

Console.WriteLine("Unit of measurement for ingredients");
Console.WriteLine(Ingredients[i,2]);

      }

Console.WriteLine("-------------------- Step preview ----------------------------");
Console.WriteLine("Number of steps: " +  numOfSteps.ToString());

  for (int i = 0; i < numOfSteps; i++) 
        { 
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Step "+(1+i).ToString());
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Description of Step");
Console.WriteLine(Steps[i,0]);        
        }
Console.WriteLine("-------------------------------------------------------------");  




Console.WriteLine("\n"+"\n"+"\n");
//Console.WriteLine("\n"+"\n"+"\n");


Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Menu");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Recipe preview                     Enter(1)");
Console.WriteLine("Scale ingredients quantity         Enter(2)");
Console.WriteLine("Reset to original value            Enter(3)");
Console.WriteLine("Clear Data                         Enter(4)");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Select");
Answer = Console.ReadLine();
        }








else if(Answer == "2")
        {
           for (int j = 0; j < numOFIngredients; j++)
          { 
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Ingredient "+(1+j).ToString());
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Quantity of ingredient");
Ingredients[j,3] =  Console.ReadLine();
Console.WriteLine("--------------------------------------------------------------");
           }

ChangedQuantity = true;

Console.WriteLine("\n"+"\n"+"\n");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Menu");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Recipe preview                     Enter(1)");
Console.WriteLine("Scale ingredients quantity         Enter(2)");
Console.WriteLine("Reset to original value            Enter(3)");
Console.WriteLine("Clear Data                         Enter(4)");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Select");
Answer = Console.ReadLine();


            }








else if (Answer == "3")
            {
 ChangedQuantity = false;
 Console.WriteLine("--------------------------------------------------------------");
 Console.WriteLine("Quantity has successfully reset to original value  ");
 Console.WriteLine("--------------------------------------------------------------");


Console.WriteLine("\n"+"\n"+"\n");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Menu");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Recipe preview                     Enter(1)");
Console.WriteLine("Scale ingredients quantity         Enter(2)");
Console.WriteLine("Reset to original value            Enter(3)");
Console.WriteLine("Clear Data                         Enter(4)");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Select");
Answer = Console.ReadLine();

            }







else if (Answer == "4")
            {
Array.Clear(Ingredients,0,Ingredients.Length);
Array.Clear(Steps,0,Steps.Length);               
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Data has been deleted");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("\n"+"\n"+"\n");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Menu");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Recipe preview                     Enter(1)");
Console.WriteLine("Scale ingredients quantity         Enter(2)");
Console.WriteLine("Reset to original value            Enter(3)");
Console.WriteLine("Clear Data                         Enter(4)");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Select");
Answer = Console.ReadLine();
            }









else if (Answer == "1" && ChangedQuantity == true)
            {

Console.WriteLine("\n"+"\n"+"\n");

Console.WriteLine("------------------- Recipe preview --------------------------");
Console.WriteLine("Number of ingredients: " +  numOFIngredients.ToString());

  for (int i = 0; i < numOFIngredients; i++) 
        { 
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Ingredient "+(1+i).ToString());
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Name of ingredient");
Console.WriteLine(Ingredients[i,0]);

Console.WriteLine("Quantity of ingredient");
Console.WriteLine(Ingredients[i,3]); 

Console.WriteLine("Unit of measurement for ingredients");
Console.WriteLine(Ingredients[i,2]);

      }

Console.WriteLine("-------------------- Step preview ---------------------------");
Console.WriteLine("Number of steps: " +  numOfSteps.ToString());

  for (int i = 0; i < numOfSteps; i++) 
        { 
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Step "+(1+i).ToString());
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Description of Step");
Console.WriteLine(Steps[i,0]);  
Console.WriteLine("--------------------------------------------------------------");
        }

Console.WriteLine("\n"+"\n"+"\n");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Menu");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Recipe preview                     Enter(1)");
Console.WriteLine("Scale ingredients quantity         Enter(2)");
Console.WriteLine("Reset to original value            Enter(3)");
Console.WriteLine("Clear Data                         Enter(4)");
Console.WriteLine("//////////////////////////////////////////////////////////////");
Console.WriteLine("Select");
Answer = Console.ReadLine();

            }
    

Console.ReadLine();

    }
  }

}
