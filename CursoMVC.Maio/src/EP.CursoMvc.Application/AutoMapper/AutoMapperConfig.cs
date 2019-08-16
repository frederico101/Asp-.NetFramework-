using AutoMapper;

namespace EP.CursoMvc.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings ()
        {
            Mapper.Initialize(x =>
            {
                
                x.AddProfile<DomainToViewModeIMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();

            });
        }
    }
}
