[![.NET Uno Build](https://github.com/GiulianoSpaghetti/numfortune.uno/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/GiulianoSpaghetti/numfortune.uno/actions/workflows/dotnet-desktop.yml)

# numerone's fortune uno

Un fortune teller per android e windows grafico in uno platform.
SI basa su helloacm.com per avre gli aforismi.

## Come installare

## Su Android

[![google](https://play.google.com/intl/it_it/badges/static/images/badges/en_badge_web_generic.png)](https://play.google.com/store/apps/details?id=org.altervista.numerone.numfortune.uno)

## Per Unix

[![pling](http://numeronesoft.ddns.net:8080/images/pling.png)](https://www.pling.com/p/2315312)

## Per Windows

Scegiere la versione che più piace dalle releases su questo sito web.

## Prerequisti

### Windows

    unigetui://DesktopRuntime
    
installare il windows desktopruntime 10

### Unix

https://learn.microsoft.com/it-it/linux/packages

Bisogna installare libice6 e libsm6 e bisogna precaricare freetype per farlo funzionare.

E' stato dimostrato che il software è perfettamente bilanciato, perché il binario viene ottimizzato dal dotnet.

Sapendo che il binario è per amd64, è possibile avviarlo con dotnet /usr/game/il_fortune_di_numerone/ilfortunedinumeronematerial.Desktop.dll sui sistemi arm64.

## Installazione col repository (GNU/Linux)
Per prima seguire la guida su https://learn.microsoft.com/it-it/dotnet/core/install/linux-debian

Poi seguire la guida su http://numeronesoft.ddns.net:8080

e poi update e instal numfortuneuno

Prerequisites:

https://learn.microsoft.com/en-us/linux/packages

Note: i pacchetti sono in IL, quindi in teoria basta reinstallare il software ad ogni update del dotnet e quindi avviare una volta il programma per ottenere il binario aggiornato.
Ovviamente se aggiornano avalonia bisogna ricompilare. runtime 9 o 10.

## Aggiornamenti

Per windows i package msix sono platform indepedent ed in IL, ma sono in dotnet 9 e 10, pr cui è necessario ricompilare per evitare di avere il sistema spurio in caso di nuovo dotnet framework che comunque è necessario per l'avvio del software, che se aggiornato dovrebbe impedire lo shock sulle ventole.


## Bug noti

Ci sono certi caratteri di escape che non vengono correttamente convertiti.

# Donazioni

http://numerone.altervista.org/donazioni.php
