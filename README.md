# Ejercicio Sockets

Este código implementa un cliente y un servidor en C# que se comunican mediante sockets y usan XML para realizar peticiones y respuestas. La funcionalidad principal es convertir el texto de la solicitud del cliente a mayúsculas y devolverlo en la respuesta

Flujo General:
- El servidor se inicia y espera conexiones en el puerto configurado.
- El cliente envía una solicitud con el texto que desea convertir.
- El servidor recibe la solicitud, convierte el texto y envía la respuesta.
- El cliente recibe y muestra el texto convertido.

## 1. Servidor (XmlServer)
El servidor escucha conexiones en una dirección IP y puerto configurados en un archivo appsettings.json. Utiliza la clase TcpListener para aceptar conexiones de los clientes y maneja cada solicitud en un nuevo hilo, **lo que permite atender múltiples clientes simultáneamente.**

### Método Arrancar:
Carga la configuración de host y port desde appsettings.json.
Inicializa el servidor en la dirección IP y puerto especificados.
En un bucle infinito, acepta conexiones de clientes usando AcceptTcpClient.
Para cada conexión de cliente, crea una instancia de la clase Conversor, que se encarga de procesar la solicitud **en un nuevo hilo** (Thread hiloProcesador).

## 2. Clase Conversor
Esta clase maneja las solicitudes de los clientes. Procesa los datos recibidos y los convierte a mayúsculas. Se conecta con la Clase **XmlConverter**

### Método ProcessRequest:
Obtiene el NetworkStream del cliente para leer y escribir datos.
Lee los datos enviados por el cliente y los convierte a texto usando Encoding.UTF8.
Usa el método ProcesarXmlConvertRequest de la clase XmlConverter para extraer y convertir el texto de la solicitud a mayúsculas.
Luego, genera una respuesta en XML (xmlResponse) con el texto convertido y la envía al cliente.
Finalmente, cierra la conexión con el cliente para liberar recursos.

## 3. Cliente (XmlClient)
El cliente permite al usuario ingresar un texto desde la consola, lo convierte en una solicitud XML y lo envía al servidor. Después, espera una respuesta con el texto convertido a mayúsculas y lo muestra en la consola.

### Método EnviarXml:

Lee la configuración del servidor (host y port) desde appsettings.json.
Establece una conexión TCP con el servidor y obtiene el NetworkStream.
Envía la solicitud XML (creada en EnviarXmlInput) al servidor.
Recibe la respuesta XML y la muestra en la consola.

### Método EnviarXmlInput:

Recibe el texto que el usuario quiere convertir a mayúsculas y lo estructura en una solicitud XML (xmlRequest).
Llama a EnviarXml para enviar esta solicitud al servidor.

## 4. Clase XmlConverter
Esta clase contiene métodos para manejar el XML, extrayendo el texto de la solicitud y generando la respuesta en XML.

### Método ProcesarXmlConvertRequest:

Recibe el XML de la solicitud, analiza el nodo <from> y convierte el texto contenido a mayúsculas.
Devuelve el texto convertido.
Método GenerarPaqueteXmlConvertResponse:

Crea un XML de respuesta que incluye el texto convertido en un nodo <texto> dentro de un nodo raíz <ConvertResponse>.
Método GenerarPaqueteXmlConvertResponseError:

Genera un paquete XML de error con un mensaje especificado, útil para manejar errores en el procesamiento de la solicitud.
