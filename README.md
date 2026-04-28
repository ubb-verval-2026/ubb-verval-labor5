# VerVal - Labor 5

**1. (4 pont)** Telepíts Android SDK-t (a legegyszerűbb, ha a Visual Studióban felrakod a mobile development csomagot, de más módszer is megengedett), valamint egy Appium Servert és Inspectort. Ezt a setup-t elég bemutatni a laborvezetőnek (nem kell commit hozzá): igazold a működő környezetet egy emulátoros telefon inspekciójával, vagy egyszerűen a későbbi feladatok sikeres futtatásával.

**2. (4 pont)** Fogd a webes felülethez már megírt `Person_SalaryIncrease_ShouldIncrease` tesztet, és implementáld a mobilalkalmazásra is! A kód kerüljön egy új, különálló tesztosztályba. (a mobilapplikáció csak pozitív számokat fogad el)

**3. (4 pont)** Tölts le egy tetszőleges, ismert alkalmazást (pl. Wizz Air, eMAG, Glovo, Star Taxi stb...) az emulátorodra vagy a saját telefonodra. Írj egy automatizációt, ami végigkattint egy teljes felhasználói folyamatot egészen a rendelés vagy foglalás véglegesítése előtti pontig. A tényleges fizetést már nem kell leprogramoznod (pénzzel nem játszunk:)).

#### Szemis Appium inspector config:
```
{
"platformName": "Android",
"appium:deviceName": "emulator-5554",
"appium:appPackage": "com.BBTE.VerVal",
"appium:appActivity": "com.BBTE.VerVal.MainActivity",
"appium:automationName": "UiAutomator2",
"appium:noReset": true
}
```
