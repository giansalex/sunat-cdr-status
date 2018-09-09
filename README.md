# CDR Status
Ejemplo para consultar el estado de una factura y obtención del CDR.

## Pasos
- Configurar las credenciales en `App.config`
```xml
 <wsse:Security xmlns:wsse="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd">
  <wsse:UsernameToken >
    <wsse:Username>201234567891MODDATOS</wsse:Username>
    <wsse:Password>moddatos</wsse:Password>
  </wsse:UsernameToken>
</wsse:Security>
```

- En `Program.cs`, rellenar la informacion de la factura a consultar
```cs
//...
var result = service.getStatus(
 rucComprobante: "201234567891",
 tipoComprobante: "01",
 serieComprobante: "F001",
 numeroComprobante: 200
);
//...
```
