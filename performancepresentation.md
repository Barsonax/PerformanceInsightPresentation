---
theme : "white"
transition: "slide"
highlightTheme: "vs2015"
slideNumber: true
logoImg: "https://github.com/Barsonax/nukepresentation/raw/master/images/nukeIcon.png"
title: "Performance insight presentation"
enableTitleFooter: false
---

## Performance Insight

<a>
    <img style="border: unset; box-shadow: unset" data-src="https://github.com/Barsonax/nukepresentation/raw/master/images/nukeIcon.png">
</a>

---

## In deze presentatie

- Meten is weten
- Profiler
- BenchmarkDotNet
- Vragen

---

## Meten is weten

- Gericht oplossen van problemen
- Performance is ook een feature
- Niet altijd duidelijk vanuit de code

--

## De don'ts

- Debug mode
- Debugger

--

## Stopwatch

- Simpel
- Vergt code aanpassingen
- Handig voor logging

```cs
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Thread.Sleep(10000);
stopWatch.Stop();
// Get the elapsed time as a TimeSpan value.
TimeSpan ts = stopWatch.Elapse
// Format and display the TimeSpan value.
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);
```

---

## Vragen
