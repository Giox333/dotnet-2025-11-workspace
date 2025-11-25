using System;
using System.Collections;
public class CentraleSmistaPosta
{
    private string _codiceCentrale;
    public string CodiceCentrale
    {
        get => this._codiceCentrale;
        set => this._codiceCentrale = value;
    }
    private ArrayList _lettere;
    public ArrayList Letter
    {
        get => this._lettere;
    }
    public CentraleSmistaPosta() : this("1234") { }
    public CentraleSmistaPosta(string codice)
    {
        this._codiceCentrale = codice;
        this._lettere = new ArrayList();
    }
    public void RiceviLettera(Lettera lettera)
    {
        if (lettera == null)
            return;
        this._lettere.Add(lettera);
    }
    public Lettera? SmistaLettera()
    {
        if (_lettere.Count == 0)
            return null;
        int max = 0, i,posizione=0;
        bool lettereNonPrio = true;
        for (i = 0; i < _lettere.Count; i++)
        {
            if (this._lettere[i] is LetteraPrioritaria)
            {
                lettereNonPrio = false;
                LetteraPrioritaria letteraTemp = (LetteraPrioritaria)this._lettere[i]!;
                if (letteraTemp.Priorità > max){
                    max = letteraTemp.Priorità;
                    posizione = i;
                    //System.Console.WriteLine($"Max cambiato in = {max}\n");
                }
            }
        }
        return lettereNonPrio ? (Lettera)this._lettere[0]! : (Lettera)this._lettere[posizione]!;
    }
    public override string ToString()
    {
        string testo = $"Centrale = {_codiceCentrale}, Lettere:";
        foreach (var lettera in _lettere)
        {
            testo = testo + "\n" + lettera.ToString();
        }
        return testo;
    }
}