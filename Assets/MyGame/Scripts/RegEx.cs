using UnityEngine;
using System.Text.RegularExpressions;

public class RegEx : MonoBehaviour
{
    void Start()
    {
        string input = "Kontakt: lisa@example.com, support@test.org oder info@firma.de.";

        // Einfache Regex für E-Mails
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Debug.Log("Gefundene E-Mail: " + match.Value);
        }
    }
}
