# Rezervacija termina za instrukcije

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Antonio Valent | avalent@foi.hr | 0016141906 | avalent1
Antonio Rusak | arusak@foi.hr | 0016141815 | arusak1
Karlo Orejaš | korejas@foi.hr | 0016143916 | korejas
Jakov Lisjak| jlisjak@foi.hr | 0016142102 | jlisjak1

## Opis domene
Pomoću ove aplikacije njezini korisnici bi mogli rezervirati termin primanja ili oglasiti termin pružanja instrukcija. Korisnici naše aplikacije su ljudi kojima su potrebne usluge instrukcija iz raznih predmeta u srednjoj školi ili na fakultetu, a isto tako i korisnici koje te instrukcije pružaju. Korisnici koji pružaju ove usluge izrade oglas u kojem su navedeni podaci poput informacija o davatelju usluga, njegovoj lokaciji, cijeni, predmetu iz kojeg pruža ove usluge i slično. Korisnici kojima su ove usluge potrebne mogu filtrirati i pretraživati oglase po lokaciji, predmetu i sličnim kriterijima. Nakon što su iskoristili dane usluge, moguće je ostaviti recenziju kako bi drugima olakšali odabir prilikom potrage. Glavni cilj ove aplikacije je pomoći studentima i učenicima u njihovom školovanju.

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------  | ----- | ----------- | -------------------
FO1 | Prijava i registracija | Prijava ili registracija budućih članova aplikacije i odabir uloge zbog koje se registriraju(instruktor ili učenik). Koristi se 2faktorska autentifikacija | Karlo Orejaš
FO2 | Kreiranje oglasa | Instruktor izrađuje oglas u kojem navodi sve potrebne informacije za održavanje instrukcija | Karlo Orejaš
FO3 | Pretraživanje oglasa | Učenici imaju mogućnost filtriranja po različitim kriterijima(lokacija, cijena, vrijeme itd.) | Antonio Rusak
F04 | Odabir oglasa | Učenik odabire željeni oglas u kojem su prikazane sve informacije koje je instruktor naveo | Antonio Rusak
FO5 | Davanje recenzije | Nakon što se instrukcija održi učenik može dati ocjenu i komentar instruktoru | Jakov Lisjak
FO6 | Zakazivanje termina instrukcija | Nakon odabira oglasa korisnik mora odabrati neki termin koji mu odgovara u popisu termina koje je instruktor naveo kod izrade oglasa | Jakov Lisjak
FO7 | Kalendarski pregled instrukcija u tjednu nekog instruktora | Može se vidjeti kalendar svih instrukcija nekog instruktora u tjednu | Antonio Valent
FO8 | Pregled odrađenih instrukcija od strane instruktora | Može se vidjeti popis instrukcija koje je instruktor odradio | Antonio Valent
F09 | Pregled odrađenih instrukcija od strane korisnika | Može se vidjeti popis instrukcija na kojima je korisnik bio | Karlo Orejaš
F10 | Izdavanje računa korisniku za instrukcije | Nakon što je korisnik odabrao termin oglasa na koji bi došao instruktor mora pričekati da prođe rok u kojem korisnik još uvijek može otkazati instrukcije te kada prođe taj rok tada izdaje račun | Antonio Rusak
F11 | Otkazivanje termina instrukcija | Korisnik može otkazati termin insktrukcija do određenog roka, ako do tog roka ne otkaže, a ne dođe na instrukcije mora platiti kao da je bio na instrukcijama | Jakov Lisjak
F12 | Pregled recenzija nekog instruktora | Može se vidjeti popis recenzija koje su ostavili korisnici nekom instruktoru ili na nekom oglasu koji je instruktor održao | Antonio Valent

## Tehnologije i oprema
Microsoft Visual Studio 2022, C# (.NET Framework), Microsoft SQL Server, GitHub, Microsoft Word
