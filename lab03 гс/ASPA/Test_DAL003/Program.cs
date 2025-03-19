using System;
using System.Text;
using DAL003;

public class Program
{
	private static void Main(string[] args)
	{
		using (IRepository repository = Repository.Create("Celebrities"))
		{
			foreach (Celebrity celebrity in repository.getAllCelebrities())
			{
				Console.WriteLine($"Id = {celebrity.Id}, Firstname = {celebrity.Firstname}, " +
						  $"Surname = {celebrity.Surname}, PhotoPath = {celebrity.PhotoPath}");
			}

			Celebrity? celebrity1 = repository.GetCelebrityById(1);
			if (celebrity1 != null)
			{
				Console.WriteLine($"Id = {celebrity1.Id}, Firstname = {celebrity1.Firstname}, " +
						  $"Surname = {celebrity1.Surname}, PhotoPath = {celebrity1.PhotoPath}");
			}
            Celebrity? celebrity2 = repository.GetCelebrityById(2);
            if (celebrity2 != null)
            {
                Console.WriteLine($"Id = {celebrity2.Id}, Firstname = {celebrity2.Firstname}, " +
                          $"Surname = {celebrity2.Surname}, PhotoPath = {celebrity2.PhotoPath}");
            }

            Celebrity? celebrity3 = repository.GetCelebrityById(3);
			if (celebrity3 != null)
			{
				Console.WriteLine($"Id = {celebrity3.Id}, Firstname = {celebrity3.Firstname}, " +
						  $"Surname = {celebrity3.Surname}, PhotoPath = {celebrity3.PhotoPath}");
			}
            Celebrity? celebrity4 = repository.GetCelebrityById(4);
            if (celebrity4 != null)
            {
                Console.WriteLine($"Id = {celebrity4.Id}, Firstname = {celebrity4.Firstname}, " +
                          $"Surname = {celebrity4.Surname}, PhotoPath = {celebrity4.PhotoPath}");
            }


            Celebrity? celebrity7 = repository.GetCelebrityById(7);
			if (celebrity7 != null)
			{
				Console.WriteLine($"Id = {celebrity7.Id}, Firstname = {celebrity7.Firstname}, " +
						  $"Surname = {celebrity7.Surname}, PhotoPath = {celebrity7.PhotoPath}");
			}

			Celebrity? celebrity222 = repository.GetCelebrityById(222);

			if (celebrity222 != null)
			{
				Console.WriteLine($"Id = {celebrity222.Id}, Firstname = {celebrity222.Firstname}, " +
						  $"Surname = {celebrity222.Surname}, PhotoPath = {celebrity222.PhotoPath}");
			}
			else
			{
				Console.WriteLine("Not Found 2222");
			}

			foreach (Celebrity celebrity in repository.GetCelebritiesBySurname("Chomsky"))
			{
				Console.WriteLine($"id = {celebrity.Id}, Firstname = {celebrity.Firstname}, " +
						  $"Surname = {celebrity.Surname}, PhotoPath = {celebrity.PhotoPath}");
			}

			foreach (Celebrity celebrity in repository.GetCelebritiesBySurname("Knuth"))
			{
				Console.WriteLine($"id = {celebrity.Id}, Firstname = {celebrity.Firstname}, " +
						  $"Surname = {celebrity.Surname}, PhotoPath = {celebrity.PhotoPath}");
			}

			foreach (Celebrity celebrity in repository.GetCelebritiesBySurname("XXXX"))
			{
				Console.WriteLine($"id = {celebrity.Id}, Firstname = {celebrity.Firstname}, " +
						  $"Surname = {celebrity.Surname}, PhotoPath = {celebrity.PhotoPath}");
			}

			Console.WriteLine($"PhotoPathById = {repository.getPhotoPathById(5)}");
			Console.WriteLine($"PhotoPathById = {repository.getPhotoPathById(6)}");
			Console.WriteLine($"PhotoPathById = {repository.getPhotoPathById(222)}");

		}
	}

}
