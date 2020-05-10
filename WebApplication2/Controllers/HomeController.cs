using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string group1, string group2, string group3, string group4, string group5, string group6, string group7, string group8, string group9, string group10)
        {
            
            int result = 0;
            string res;
            string ans1 = group1;
            if (ans1 != "value1") { ans1 = "You answer is not correct! Correct answer is value 1\n "; } else { ans1 = "Correct\n"; result++; }
            string ans2 = group2;
            if (ans2 != "value1") { ans2 = "You answer is not correct! Correct answer is value 1\n "; } else { ans2 = "Correct\n"; result++; }
            string ans3 = group3;
            if (ans3 != "value1") { ans3 = "You answer is not correct! Correct answer is value 1\n"; } else { ans3 = "Correct\n"; result++; }
            string ans4 = group4;
            if (ans4 != "value1") { ans4 = "You answer is not correct! Correct answer is value 1\n "; } else { ans4 = "Correct\n"; result++; }
            string ans5 = group5;
            if (ans5 != "value1") { ans5 = "You answer is not correct! Correct answer is value 1\n "; } else { ans5 = "Correct\n"; result++; }
            string ans6 = group6;
            if (ans6 != "value1") { ans6 = "You answer is not correct! Correct answer is value 1\n "; } else { ans6 = "Correct\n"; result++; }
            string ans7 = group7;
            if (ans7 != "value1") { ans7 = "You answer is not correct! Correct answer is value 1\n "; } else { ans7 = "Correct\n"; result++; }
            string ans8 = group8;
            if (ans8 != "value1") { ans8 = "You answer is not correct! Correct answer is value 1\n "; } else { ans8 = "Correct\n"; result++; }
            string ans9 = group9;
            if (ans9 != "value1") { ans9 = "You answer is not correct! Correct answer is value 1\n "; } else { ans9 = "Correct\n"; result++; }
            string ans10 = group10;
            if (ans10 != "value1") { ans10 = "You answer is not correct! Correct answer is value 1\n "; } else { ans10 = "Correct\n"; result++; }
            if (result < 5) { res = "You bad player"; } else if (result >= 5 && result < 9) { res = "You middle player"; } else { res = "You pro player! Grats"; }
            string authData = $"q1: {ans1}   \nq2: {ans2}   \nq3: {ans3}  \nq4: {ans4} \nq5: {ans5} \nq6: {ans6} \nq7: {ans7} \nq8: {ans8} \nq9: {ans9} \nq10: {ans10} \nResult:You have  {result} points \n{res}" ;
            return Content(authData);
        }
        public IActionResult Indexuk()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Indexuk(string group1, string group2, string group3, string group4, string group5, string group6, string group7, string group8, string group9, string group10)
        {

            int result = 0;
            string res;
            string ans1 = group1;
            if (ans1 != "value1") { ans1 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans1 = "Ви відповіли правильно\n"; result++; }
            string ans2 = group2;
            if (ans2 != "value1") { ans2 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans2 = "Ви відповіли правильно\n"; result++; }
            string ans3 = group3;
            if (ans3 != "value1") { ans3 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans3 = "Ви відповіли правильно\n"; result++; }
            string ans4 = group4;
            if (ans4 != "value1") { ans4 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans4 = "Ви відповіли правильно\n"; result++; }
            string ans5 = group5;
            if (ans5 != "value1") { ans5 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans5 = "Ви відповіли правильно\n"; result++; }
            string ans6 = group6;
            if (ans6 != "value1") { ans6 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans6 = "Ви відповіли правильно\n"; result++; }
            string ans7 = group7;
            if (ans7 != "value1") { ans7 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans7 = "Ви відповіли правильно\n"; result++; }
            string ans8 = group8;
            if (ans8 != "value1") { ans8 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans8 = "Ви відповіли правильно\n"; result++; }
            string ans9 = group9;
            if (ans9 != "value1") { ans9 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans9 = "Ви відповіли правильно\n"; result++; }
            string ans10 = group10;
            if (ans10 != "value1") { ans10 = "Ваша відповідь неправильна! Правильна відповідь 1\n "; } else { ans10 = "Ви відповіли правильно\n"; result++; }
            if (result < 5) { res = "Ви поганий гравець ,не грайте в Доту 2 ніколи!"; } else if (result >= 5 && result < 9) { res = "Ви гравець середнього рівня"; } else { res = "Про ігрок! Вітаємо!Вам дорога в кіберспорт"; }
            string authData = $"Питання1: {ans1}   \nПитання2: {ans2}   \nПитання3: {ans3}  \nПитання4: {ans4} \nПитання5: {ans5} \nПитання6: {ans6} \nПитання7: {ans7} \nПитання8: {ans8} \nПитання9: {ans9} \nПитання10: {ans10} \nРезультатеуфtea:Ви набрали  {result} бал(ів) \n{res}";
            return Content(authData);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public void Check()
        {
            
        }
    }
}
