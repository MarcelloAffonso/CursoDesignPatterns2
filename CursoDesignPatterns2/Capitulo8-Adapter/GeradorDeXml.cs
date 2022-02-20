using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CursoDesignPatterns2
{
    public class GeradorDeXml
    {
        public string GeraXml(object objeto)
        {
            // Cria um serializador da classe do objeto
            XmlSerializer serializer = new XmlSerializer(objeto.GetType());

            // Cria um stringWriter, que armazenará o objeto serializado
            StringWriter writer = new StringWriter();

            // Serializa o objeto no string writer
            serializer.Serialize(writer, objeto);

            // Retorna a versão do xml serializada em string
            return writer.ToString();
        }
    }
}
