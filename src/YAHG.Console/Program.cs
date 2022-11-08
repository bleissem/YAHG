using YAHG.Common;
using YAHG.Common.Factories;

SpielFactory factory = new SpielFactory();

Spiel spiel = factory.CreateSpiel(new SpielKonfiguration()
{
    AnzahlSpieler = 4,
    AnzahlFarben = 4
});

