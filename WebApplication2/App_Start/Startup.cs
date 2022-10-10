using Microsoft.Owin;
using Namotion.Reflection;
using Newtonsoft.Json.Schema;
using NSwag.AspNet.Owin;
using NSwag.Generation;
using Owin;

[assembly: OwinStartup(typeof(WebApplication2.App_Start.Startup))]

namespace WebApplication2.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseSwaggerUi3(typeof(Startup).Assembly, config =>
            {
                config.Path = "/swagger";
                config.DocumentPath = "/swagger/open-api.json";
                config.GeneratorSettings.SchemaType = NJsonSchema.SchemaType.OpenApi3;
                // config.AdditionalSettings["url"] = "/swagger/v1/open-api.json";
                // config.GeneratorSettings.SerializerSettings.
                config.GeneratorSettings.SchemaGenerator = new AAA(config.GeneratorSettings);
            });

            app.UseSwaggerReDoc(typeof(Startup).Assembly, config =>
            {
                config.Path = "/redoc";
                config.DocumentPath = "/redoc/open-api.json";
                config.GeneratorSettings.SchemaType = NJsonSchema.SchemaType.OpenApi3;
                //config.AdditionalSettings["url"] = "/swagger/v1/open-api.json";
            });

            // JsonSchemaGenerator
        }


    }

    internal class AAA : OpenApiSchemaGenerator {
        public AAA(OpenApiDocumentGeneratorSettings settings) : base(settings)
        { 
        }

        public override void Generate<TSchemaType>(TSchemaType schema, ContextualType contextualType, NJsonSchema.Generation.JsonSchemaResolver schemaResolver)
        {
            base.Generate(schema, contextualType, schemaResolver);
        }
         
    }
}
