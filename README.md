# curso_net_first_api
### Consigas:

* Construir una enteidad con 6 propiedades (una el Id tipo int)
-- Dentro de la carpeta "Entities" vamos a crear una nueva clase 
(Ivan: Serie, Nicolás: Game, Neyen: Neyen: Album)
-- Definir una propiedad "id" tipo int y pensar 5 más, (que no sean todas string..)
* Registrar el dbSet en el dataContext
-- Ir al archivo DataContext.cs y registrar el DbSet<> de nuestra entidad
* Crear un populate controller que cree datos de nuestra entidad
-- En el populateController tenemos ya la estructura para el llamado a un service que llena la data.
-- Vamos a ese service (ver nuestro método 'FillDataEntidad') y dentro tenemos la estructura para crear algunos elementos, llenar con información real en base a las propiedades que hayamos pensado para nuestra entidad
* Crear controller y service
-- Crear el controller de nuestra entidad con 2 métodos: GetAll y GetById, basarse en el controllador de Movies para ver cómo
-- Ese controller va a llamar a un método que está en nuestro Service, crear nuestro Service, basarse en el MovieService para ver la estructura y reemplazar lo que sea propio de nuestra entidad.

### Endpoints

* FillData() => 
>GET _ https://localhost:44398/api/populate/{entity}
* GetAll => 
>GET _ https://localhost:44398/api/{entity}
* GetById => 
>GET _ https://localhost:44398/api/populate/{entity}/{id}

