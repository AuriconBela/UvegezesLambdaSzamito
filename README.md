# Üvegezés Lambda Számító

Ez egy .NET 8 konzolos alkalmazás, amely az üvegezés fiktív lambda értékének számítását végzi.

## Használat
1. Futtasd az alkalmazást:
   ```
   pwsh
   dotnet run
   ```
2. Add meg a kért adatokat (csak pozitív számokat fogad el):
   - Üvegezés vastagsága (mm)
   - U<sub>g</sub> érték (W/m²K)
   - R<sub>si</sub> érték (alapértelmezett: 0.04 m²K/W)
   - R<sub>se</sub> érték (alapértelmezett: 0.13 m²K/W)
3. Az alkalmazás kiszámolja és kiírja a λ értéket.
4. A kilépéshez nyomj meg egy gombot.

## Követelmények
- .NET 8 SDK

## Fő képlet
λ = -(d/(R<sub>se</sub> + R<sub>si</sub> - 1/U<sub>g</sub>))
