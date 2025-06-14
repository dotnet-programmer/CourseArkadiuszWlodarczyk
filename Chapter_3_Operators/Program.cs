#region Chapter 3.1 Arithmetic operators and assignments
Console.WriteLine("Chapter 3.1 Arithmetic operators and assignments");
int a = 7, b = 10, c;
//a += 7; // a = a + 7
//a -= 5; // a = a - 5
a /= 3; // a = 7 / 3 = 2 (i 1 / 3) - to jest usunięte ponieważ operujemy na liczbach całkowitych
Console.WriteLine(a);
// 23 % 10 = 2 i 3 / 10
// 7 % 3 = 2 i 1 / 3
/*
Console.WriteLine(a + " + " + b + " = " + (a + b));
Console.WriteLine(a + " - " + b + " = " + (a - b));
Console.WriteLine(a + " / " + b + " = " + (a / (double)b));
Console.WriteLine(a + " * " + b + " = " + (a * b));
Console.WriteLine(a + " % " + b + " = " + (a % b));
*/
//POSTINKREMENTACJA
/*
Console.WriteLine(a++);
Console.WriteLine(a);
Console.WriteLine(a);
*/
//PREINKREMENTACJA
/*
Console.WriteLine(++a);
Console.WriteLine(a);
Console.WriteLine(a);
*/
//POSTDEKREMENTACJA
/*
Console.WriteLine(a--);
Console.WriteLine(a);
Console.WriteLine(a);
*/
//PREDEKREMENTACJA
/*
Console.WriteLine(--a);
Console.WriteLine(a);
Console.WriteLine(a);
*/
Console.ReadLine();
#endregion Chapter 3.1 Arithmetic operators and assignments

#region Chapter 3.2 Relational operators (comparisons)
Console.WriteLine("Chapter 3.2 Relational operators (comparisons)");
bool bool1 = true;
int zm1 = 4, zm2 = 5;
Console.WriteLine(zm1 >= zm2);
/* == - zwróci prawdę (true) wtedy i tylko wtedy, gdy elementy są równe!
 * != - zwróci true, wtedy gdy elementy są nierówne
 * a > b - zwróci true, wtedy gdy element a jest większy od elementu b
 * a < b - zwróci true, wtedy gdy element a jest mniejszy od elementu b
 * a <= b - zwróci true, wtedy gdy element a jest mniejszy bądź też równy elementowi b
 * a >= b - zwróci true, wtedy gdy element a jest większy bądź tez równy elementowi b */
Console.ReadLine();
#endregion Chapter 3.2 Relational operators (comparisons)

#region Chapter 3.3 Logical operators
Console.WriteLine("Chapter 3.3 Logical operators");
// Console.WriteLine( ((12 > 7) && (9 > 4)) && (4 != 4));
Console.WriteLine(!((5 == 5) || (4 == 2)));
/* KONIUNKCJA - (i) - && - koniukcja jest prawdziwa wtedy i tylko wtedy, gdy OBA wyrażenia są prawdziwe
 * wyr1 wyr2   wynik
 * true true   true
 * true false  false
 * false true  false
 * false false false
 *
 * ALTERNATYWA - (lub) - || - alternatywa jest fałszywa wtedy i tylko wtedy, gdy OBA wyrażenia są fałszywe
 * wyr1 wyr2 wynik
 * true true true
 * true false true
 * false true true
 * false false false
 *
 * ZAPRZECZENIE - negacja - !
 * !(true) wynikiem bedzie false
 * !(false) wynikiem bedzie true */
Console.ReadLine();
#endregion Chapter 3.3 Logical operators

#region Chapter 3.4 Bit operators
Console.WriteLine("Chapter 3.4 Bit operators");
/* 0 - false
 * 1 - true
 * 1 2 6 = 1 * 10 ^ 2 + 2 * 10 ^ 1 + 6 * 10 ^ 0 = 100 + 20 + 6 = 126
 * 1 0 1 0 = 0 * 2 ^ 0 + 1 * 2 ^ 1 + 0 * 2 ^ 2 + 1 * 2 ^ 3 = 0 + 2 + 0 + 8 = 10
 * 1 0 1 0 = 8 + 2 = 10 */

/* KONIUNKCJI - &
 * 1 0 1 0
 * 0 0 1 0
 * -------
 * 0 0 1 0
 * */
Console.WriteLine(10 & 2);

/* ALTERNATYWA - |
 * 1 0 1 0
 * 0 0 1 0
 * -------
 * 1 0 1 0
 * */
Console.WriteLine(10 | 2);

/* ALTERNATYWA WYKLUCZAJĄCĄ (XOR) - ^ (albo)
 * 1 0 1 0
 * 0 0 1 0
 * -------           wyr1 wyr2 wynik
 * 1 0 0 0            0     0    0
 *                    0     1    1
 *                    1     0    1
 *                    1     1    0
 * */
Console.WriteLine(10 ^ 2);

/* ~ - negacja
 * ~(1 0 1 0) = (0 1 0 1) */
Console.WriteLine(~10);

/* 10 << 1
 *  0 0 0 0 0 0 0 1 0 1 0 (8 + 2)
 *  0 0 0 0 0 0 1 0 1 0 0 (8 + 2) * 2 = (8 * 2 + 2 * 2) = (20)
 *  10 >> 1
 *  0 0 0 0 0 0 0 1 0 1 0 (8 + 2)
 *  0 0 0 0 0 0 0 0 1 0 1 (8 + 2) / 2 = (4 + 1) = 5 */
Console.WriteLine(10 << 3);
Console.WriteLine(10 >> 1);
Console.ReadLine();
#endregion Chapter 3.4 Bit operators