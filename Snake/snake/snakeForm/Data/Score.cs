using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using snakeForm.logica;

namespace SnakeForm.Data;

public class Score
{
 
    public String SourceFile = SnakeForm.Properties.Resources.SourceFile;
    public List<string> ScoreList { get; set; }
    private int _points;
    public int Points
    {
        get => _points;
        set
        {
            if (value < 0) throw new ArgumentException("Score lager dan 0");
            _points = value;
        }
    }
    String line = "";
    public async Task ReadFile()
    {
        var sr = new StreamReader(SourceFile);
        try
        {
            if (File.Exists(SourceFile))
            {
                try
                {
                    
                    while (!sr.EndOfStream)
                    {
                        line = await sr.ReadLineAsync();
                        if (!String.IsNullOrEmpty(line))
                        {
                            
                            ScoreList.Add(line);
                        }
                    }
                }
                catch (IOException e)
                {
                    throw new IOException($"The file could not be read { e.Message}");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Fout { ex.Message}");
                }
                finally
                {
                    if (sr != null) sr.Dispose();
                }
            }
        }
        catch (FileNotFoundException filenotfound)
        {
            throw new FileNotFoundException($"FIle not found{ filenotfound.Message}");
        }
    }

    public void WriteFile()
    {
        String scoreConvert = Convert.ToString(Points);
        if (!ScoreList.Contains(scoreConvert))
        {
            ScoreList.Add(scoreConvert);
        }
        var sw = new StreamWriter(SourceFile);
        try
        {
            if (File.Exists(SourceFile))
            {
                try
                {
                    foreach (String line in ScoreList)
                    {
                        sw.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    throw new IOException($"The file couldn't be written { e.Message}");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Fout { ex.Message}");
                }
                finally
                {
                    if (sw != null) sw.Dispose();
                }
            }
        }

        catch (FileNotFoundException filenotfound)
        {
            throw new FileNotFoundException($"FIle not found{ filenotfound.Message}");
        }
    }
}

