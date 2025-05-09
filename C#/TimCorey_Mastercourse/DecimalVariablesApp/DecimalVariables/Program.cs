

// Decimal takes more space then double so it is only used for money and astronomical values.
// To use a decimal we need to put a 'M' after the number or the system will not be able to convert it.


decimal bankAccountBalance = 2.34M;

Console.WriteLine(bankAccountBalance);


