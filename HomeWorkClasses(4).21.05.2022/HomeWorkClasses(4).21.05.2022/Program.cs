using System;

class HomeWork
{

    public static void Main()
    {
        User user1 = new User
        {
            name = "Nurlan",
            password = "123mammadov123"

        };

        Console.WriteLine(user1.IsPasswordValid());
    }
}

class User
{

    public string name;
    public string password;

    public bool IsPasswordValid()
    {

        if (IsLengthValid() == true && IsNameHasPassword() == true && IsNumberValid() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public bool IsNumberValid()
    {
        char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        for (int i = 0; i < password.Length; i++)
        {
            for (int j = 0; j < number.Length; j++)
            {
                if (password[i] == number[j])
                {
                    return true;
                    
                }
            }
        }
        return false;
    }

    public bool IsLengthValid()
    {
        int length = 6;
        if (password.Length > length)
        {
            return true;
        }
        return false;

    }


    public bool IsNameHasPassword()
    {

        string passwordLower = password.ToLower();
        string nameLower = name.ToLower();
        string forChecking = "";
        for (int i = 0; i < password.Length; i++)
        {

            for (int j = 0; j < name.Length; j++)
            {

                if (passwordLower[i] == nameLower[j])
                {

                    forChecking += passwordLower[i];
                    break;
                }
                else if (forChecking == nameLower)
                {
                    return false;

                }

            }

        }
        return true;
    }

}