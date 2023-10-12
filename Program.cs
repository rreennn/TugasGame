// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string divisiGame;
// divisiGame = "Hore";
// Console.WriteLine(divisiGame);
// var divisi = "Game"; //bisa untuk berbagai type data
// var angka = 3;
// Console.WriteLine(divisi);
// Console.WriteLine(angka);
// const float phi = 3.14f; //float harus memakai f di belakangnya
// //phi = 56.8f; -> tidak bisa diganti karena const
// string name = "ucup";
// Console.WriteLine(name);
// Console.WriteLine(phi);

// int umur = 20;
// double tinggiBadan = 167.7;
// float phi = 3.14f;

// string firstName;
// string lastName = "Karenaningtyas";
// Console.WriteLine("Masukkan Nama Depan");
// firstName = Console.ReadLine();
// Console.WriteLine(firstName + " " + lastName);

// string hari = "Senin \t Selasa \t Rabu \t Kamis \t Jumat \t Sabtu \t Minggu";
// string bulan = "\r\nJanuari \r\nFebruari \r\nMaret \r\nApril \r\n";
// string film = "\"One Piece\" Suzume\" Kimi no Nawa\" Detective Conan\"";

// Console.WriteLine(hari);
// Console.WriteLine(bulan);
// Console.WriteLine(film);

// string txt = "goOd MorNinG y'ALl";
// string txtUpper = txt.ToUpper();
// string txtLower = txt.ToLower();
// Console.WriteLine(txt);
// Console.WriteLine(txtUpper);
// Console.WriteLine(txtLower);
// Console.WriteLine("There's " + txt.Length + " characters btw, nice fact isn't it?");

// string name;
// var date = DateTime.Now;
// var day = date.Day;
// var month = date.Month;
// var year = date.Year;
// Console.WriteLine("What's ur name?");
// name = Console.ReadLine();
// Console.WriteLine($"{date.DayOfWeek}, {day}/{month}/{year} {date:HH:mm} WIB. Hi {name}!");

// string name = "Keren";
// string hari = "Sabtu";
// string perasaan = "Senang";
// Console.WriteLine($"Hari {hari}, {name} merasa {perasaan} karena mengikuti pelatihan BTNG");

// var date = DateTime.Now;
// var bulan = date.ToString("MMMM yyyy");
// Console.WriteLine(bulan);

// bool benar = true;
// bool salah = false;

// if(benar == false) {
//     Console.WriteLine("Kamu bener tapi salah :)");
// } else {
//     Console.WriteLine("Kamu salah tapi bener :)");
// }

// int angkaInt = 50;
// float angkaFloat = angkaInt;

// float angka1 = 3.56f;
// int angka2 = (int)angka1;

// Console.WriteLine(angkaFloat);
// Console.WriteLine(angka2);

// int angkaToString = 90;
// Console.WriteLine($"String angka : {angkaToString.ToString()}");

// string pertama = "10";
// string kedua = "5";
// int sum = int.Parse(pertama) + int.Parse(kedua);
// Console.WriteLine(sum);

// var hasil = 10 + 14;
// var hasil1 = 50 -29;
// var hasil2 = 29 - 23;
// var hasil3 = 5 * 4;
// var hasil4 = 20 / 4;
// var hasil5 = 30 % 4;

// Console.WriteLine(hasil);
// Console.WriteLine(hasil1);
// Console.WriteLine(hasil2);
// Console.WriteLine(hasil3);
// Console.WriteLine(hasil4);
// Console.WriteLine(hasil5);

// int a = 3;
// Console.WriteLine(a);
// Console.WriteLine(++a); 
// Console.WriteLine(a);

// int b = 3;
// Console.WriteLine(b);
// Console.WriteLine(b++);
// Console.WriteLine(b);

// int c = 3;
// Console.WriteLine(c);
// Console.WriteLine(--c);
// Console.WriteLine(c);

// int d = 3;
// Console.WriteLine(d);
// Console.WriteLine(d--);
// Console.WriteLine(d);

// string[] divisi = { "web", "mobile", "game", "mulmed", "jaringan"};
// Console.WriteLine(divisi[0]);
// Console.WriteLine(divisi[1]);
// Console.WriteLine(divisi[2]);
// Console.WriteLine(divisi[3]);
// Console.WriteLine(divisi[4]);

// int[,] number = new int[2,3];
// int[,] numbers = {{ 1, 2, 3 }, {4, 5, 6}};
// Console.WriteLine(numbers[0, 1]);
// Console.WriteLine(numbers[1, 2]);

// int[,,] number = new int[2, 2, 3];
// int[,,] numbers = {{ {1, 2, 3}, {4, 5, 6} }, {{ 7, 8, 9 }, {10, 11, 12}}};
// Console.WriteLine(numbers[0, 0, 0]);
// Console.WriteLine(numbers[1, 1, 1]);

// var names = new List<string> {"Game", "Mobile", "Web"};
// for (int i = 0; i < names.Count; i++) {
//     Console.Write(names[i]+ " ");
// }

// List<int> angka = new List<int>();
// angka.Add(1);
// angka.Add(2);
// angka.Add(3);

// angka.AddRange(new int[3] {4, 5, 6});
// angka.Remove(1);
// angka.RemoveAt(0);
// angka.IndexOf(3);
// Console.WriteLine(angka.Contains(10));
// Console.WriteLine(angka.Count());

// foreach (var a in angka)
// {
//     Console.Write(a + " ");
// }

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Reflection;

// int i = 5;
// if(10 > i) {
//     Console.WriteLine("Benar!");
// } else {
//     Console.WriteLine("Salah!");
// }

// int nilai = 75;
// if (nilai >= 90) {
//     Console.WriteLine("Anda mendapat nilai A!");
// } else if(nilai < 90 && nilai >= 80) {
//     Console.WriteLine("Anda mendapat nilai B!");
// } else if(nilai < 80 && nilai >= 70) {
//     Console.WriteLine("Anda mendapat nilai C!");
// } else {
//     Console.WriteLine("Anda mendapat nilai D atau E!");
// }

// int nilai = 75;
// switch(nilai) {
//     case >= 95:
//         Console.WriteLine("Memuaskan");
//         break;
//     case >= 80:
//         Console.WriteLine("Baik");
//         break;
//     case >= 75:
//         Console.WriteLine("Cukup");
//         break;
//     default:
//         Console.WriteLine("Kurang");
//         break;
// }

// int angka = 10;
// string hasil = (angka % 2 == 0) ? "Genap" : "Ganjil";
// Console.WriteLine(hasil);

// int i = 1;
// while(i < 5) {
//     Console.WriteLine("Perulangan ke " + i);
//     i++;
// }

// int j = 5;
// do {
//     Console.WriteLine("Pengulangan ke " + j);
//     j--;
// } while(j > 0);

// int k = 0;
// int[] angka = new int[5] {1, 2, 3, 4, 5};
// foreach (int a in angka) {
//     Console.WriteLine("Ini adalah isi array urut dari indeks ke " + k++ + " yaitu " + a);
// }

// for(int i = 0; i < 10; i++) {
//     Console.WriteLine("Perulangan ke " + i);

//     if(i == 5) {
//         break;
//     }
// }

// for(int i = 0; i < 10; i++) {
//     if(i % 2 == 0) {
//         continue;
//     }
//     Console.WriteLine(i);
// }