using System;

public class User : Account
{
	private static int _id = 1;
	public int Id { get; }
	public string Fullname { get; set; }
	public int Email { get; set; }
	public int Password { get; set; }

	public override bool PasswordChecker(string password)
	{
		if (password.Length < 8||!
			password.Any(char.IsUpper)||!
			password.Any(char.IsLower)||!
			password.Any(char.IsDigit))
		{
			throw new IncorrectPasswordException("Password is wrong");
		} 
		{
			return true;

		}
		

		{

		
            
        }
	}
	public User(int email,int password)
	{
        Id = _id;
        _id++;
		Email = email;
		Password = password;
    }
    public override void ShowInfo()
    {
		Console.WriteLine($"Email:{Email}-Id:{Id}-Fullname:{Fullname}");
    }

}


