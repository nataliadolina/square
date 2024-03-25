using square_app;
using square_app.Figures;

Console.WriteLine("Enter input data (radius of the circle or triangle sides separeted by a space).");
Console.WriteLine("To stop the program tap enter");
string inputData = Console.ReadLine().Trim();
bool errorOnReadingData = false;
while (inputData != null && inputData != "")
{
    List<float> figureArgs = new List<float>();
    foreach (var letter in inputData.Split())
    {
        float num;
        if (float.TryParse(letter, out num))
        {
            figureArgs.Add(num);
        }
        else
        {
            Console.WriteLine("Invalid data was entered");
            errorOnReadingData = true;
            break;
        }
    }

    if (errorOnReadingData)
    {
        Console.WriteLine("Error on reading data occured");
        break;
    }

    else
    {
        Figure figure = null;
        try
        {
            switch (figureArgs.Count)
            {
                case 1:
                    figure = new Circle(figureArgs[0]);
                    break;
                case 3:
                    figure = new Triangle(figureArgs[0], figureArgs[1], figureArgs[2]);
                    break;
                default:
                    throw new ArgumentException("Invalid number of args.");
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (figure != null)
            {
                Console.WriteLine($"Square of the {figure} is {figure.Square()}");
            }
        }
    }

    inputData = Console.ReadLine().Trim();
}
