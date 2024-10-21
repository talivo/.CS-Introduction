decimal energyPrice = 0.03M;
int energyCurrent = 0;

Console.WriteLine("Start car charge");

Console.WriteLine("Wait on charging until cost is <= Eur 0,12");

switch(energyPrice) {
    case <= 0.05M:
        energyCurrent = 11000;
        break;
    case 0.06M:
        energyCurrent = 10000;
        break;
    case 0.07M:
        energyCurrent = 9000;
        break;
    case 0.08M:
        energyCurrent = 8000;
        break;
    case 0.09M:
        energyCurrent = 7500;
        break;
    case 0.10M:
        energyCurrent = 7000;
        break;
    case 0.11M:
        energyCurrent = 6000;
        break;
    case >= 0.12M:
        energyCurrent = 5000;
        break;
}