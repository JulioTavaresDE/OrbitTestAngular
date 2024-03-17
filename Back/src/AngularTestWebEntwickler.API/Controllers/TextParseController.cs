using Microsoft.AspNetCore.Mvc;

namespace AngularTestWebEntwickler.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TextParseController : ControllerBase
{
    public TextParseController()
    {
        
    }

    [HttpGet]
    public string Get(string str)
    {
         string strEingabe = str;
            char[] leerZeichenChar = { ' ' };
            string retEingabe = str.TrimEnd(leerZeichenChar).TrimStart();

            int countHasches = retEingabe.ToString().Count(x => x == '#');
            int countLeerzeichen = retEingabe.ToString().Count(x => x == ' ');
            string ret = string.Empty;
            string retAusgabe = string.Empty;

            for (int i = 0; i <= countHasches; i++)
            {
                if (countHasches == 6 && countLeerzeichen == 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 5 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 4 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 3 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 3 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches == 2 && countLeerzeichen == 1 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Kopfzeile</h{i}>";
                    }
                }

                if (countHasches == 2 && countLeerzeichen == 0 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i - 1}>Kopfzeile</h{i - 1}>";
                    }
                }

                if (countHasches == 1 && countLeerzeichen == 0 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = $"<h{i}>Header</h{i}>";
                    }
                }

                if (countHasches > 6 && countLeerzeichen == 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = "(zu viele Hashes)";
                    }
                }

                if (countHasches > 0 && countLeerzeichen > 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = "zu viele Leerzeichen dazwischen";
                    }
                }

                if (countHasches == 0 && countLeerzeichen == 0 && retEingabe.Contains("Header"))
                {
                    if (i == countHasches)
                    {
                        ret = "(keine Hashes)";
                    }
                }

                if (countHasches >= 0 && countLeerzeichen >= 0 && !retEingabe.Contains("Header".TrimStart().TrimEnd()) && !retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    if (i == countHasches)
                    {
                        ret = "Ungültige Zeichenkette.";
                    }
                }
            }
            return ret;
        }
    }

