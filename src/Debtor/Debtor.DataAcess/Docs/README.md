# Debtor

Projekt **Debtor** je aplikace určená pro evidenci dlužnických účtů a finančních transakcí.  
Systém umožňuje spravovat účty, zaznamenávat finanční operace a zobrazovat jejich přehled včetně aktuálního zůstatku.

Aplikace je implementována na platformě **.NET 8 (LTS pro delší podporu)** a využívá **ASP.NET Core MVC** pro webové rozhraní.  
Součástí řešení je také desktopový klient vytvořený pomocí **WinForms**, který umožňuje pracovat se stejnými daty prostřednictvím jiného uživatelského rozhraní. Oba frontendy využívají stejnou databázi a sdílí společnou logiku.

# Architektura projektu

Projekt je rozdělen do několika samostatných projektů, což umožňuje oddělit jednotlivé vrstvy aplikace a sdílet logiku mezi webovou a desktopovou částí.

Datová vrstva je implementována pomocí **Entity Framework Core**, který zajišťuje mapování databázových tabulek na C# entity a komunikaci s databází.

Použité NuGet balíčky:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`

Tyto knihovny umožňují práci s databázovým kontextem, definici entit a provádění databázových operací pomocí **LINQ dotazů**.

Samotná aplikační logika není implementována přímo ve view nebo controllerech, ale je oddělena do **knihoven tříd**, které slouží jako sdílená logická vrstva. Tyto knihovny obsahují například entity, databázový kontext a pomocné logické třídy. Díky tomu není nutné duplikovat logiku mezi jednotlivými projekty.

# Datový model

Datová struktura aplikace je postavena na dvou hlavních entitách:

- **Account**
- **AccountTransaction**

Entita `Account` reprezentuje účet v systému a obsahuje identifikační a kontaktní údaje uživatele (například jméno, email, telefon nebo datum vytvoření účtu).

Pro identifikátor účtu byl zvolen **GUID**, aby bylo možné pracovat s generovanými identifikátory místo klasického autoincrement ID.

Entita `AccountTransaction` reprezentuje jednotlivé finanční operace provedené nad účtem. Každá transakce obsahuje typ transakce, částku, měnu, datum provedení a způsob platby.

Mezi entitami existuje relace **1:N**, protože jeden účet může obsahovat více transakcí.

# Webová aplikace (ASP.NET Core MVC)

Webová část projektu je implementována pomocí **ASP.NET Core MVC**. Controllery zpracovávají HTTP požadavky, komunikují s databází a předávají data do view.

Hlavní stránkou po přihlášení je **Dashboard**, který zobrazuje základní informace o účtu, seznam transakcí a aktuální zůstatek. Pro tuto stránku je použit samostatný **ViewModel**, který obsahuje pouze data potřebná pro její zobrazení.

# Autentizace

Aplikace obsahuje autentizaci uživatelů. Přihlášení je implementováno pomocí autentizačního systému **ASP.NET Core**, kde jsou informace o přihlášeném uživateli ukládány ve formě **claims**. Tyto informace se následně využívají například při načítání účtu nebo filtrování transakcí.

# Desktopový klient (WinForms)

Vedle webové aplikace obsahuje projekt také desktopového klienta vytvořeného pomocí **WinForms**. Tento klient využívá stejné entity, databázový kontext i logickou vrstvu jako webová aplikace.

Na rozdíl od webové aplikace zde neexistuje HTTP kontext ani systém claims. Informace o přihlášeném uživateli je proto předávána mezi jednotlivými formuláři pomocí **konstruktorů**. Formulář otevřený po přihlášení obdrží v konstruktoru identifikátor nebo objekt uživatele a tento objekt následně předává dalším formulářům.

Tím je zajištěno, že všechny operace jsou prováděny v kontextu správného účtu bez použití globálních proměnných.

# Možná budoucí rozšíření

Přestože aplikace implementuje základní funkcionalitu, existuje několik oblastí, které by bylo možné dále rozšířit.

Možným rozšířením je například implementace **systému úroků**, který by umožnil automatický výpočet úroků z dlužných částek. Dále by bylo možné rozšířit **validaci vstupních dat** například o limity transakcí nebo kontrolu záporného zůstatku.

Z bezpečnostního hlediska by bylo vhodné implementovat **systém rolí** místo současné kontroly administrátora pouze podle emailu a zároveň ukládat hesla pomocí **hashování**.

Z hlediska uživatelského rozhraní by bylo možné přidat například **light/dark mode**, notifikace o provedených operacích nebo grafické statistiky vývoje dluhu.

Další možné rozšíření zahrnuje podporu **více účtů pro jednoho uživatele**, lokalizaci aplikace (např. CZ/EN), import a export dat nebo rozšíření administrátorských funkcí pro správu uživatelů.

# Shrnutí

Architektura aplikace je navržena tak, aby oddělovala jednotlivé vrstvy systému a umožňovala znovupoužitelnost kódu. Datová vrstva, aplikační logika a uživatelská rozhraní jsou oddělena do samostatných projektů. Díky tomu mohou webová i desktopová aplikace využívat stejnou logiku a pracovat se stejnými daty.