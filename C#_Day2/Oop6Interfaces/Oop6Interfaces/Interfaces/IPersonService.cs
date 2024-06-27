namespace Oop6Interfaces.Interfaces;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    void AddAddress(string adr);
    List<string> GetAddress();
}

