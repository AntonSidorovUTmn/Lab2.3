/*
 *Лабораторная: 2.3.
 *Источник: Hwmw.Blogspot.com
 *
 *Язык: C Sharp (C#) v7.3.
 *Среда: Microsoft Visual Studio 2019 v16.7.6.
 *Платформа: .NET Framework v4.7.2.
 *API: console.
 *Изменение: 28.11.2020.
 *Защита: 14.12.2020.
 *
 *Задание: дополните папку из Лаб 2.2 новыми библиотеками написанными на C, C++ и Delphi (Lazarus). Проверьте их
 *     рабочеспособность запустив программу из Lab 2.2.
 */

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    static class Program {
        [STAThread]

        static void Main () {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}