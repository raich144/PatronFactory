namespace PatronFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatorA creatorA = new CreatorA();
            CreatorB creatorB = new CreatorB();
            CreatorC creatorC = new CreatorC();

            Console.WriteLine("Crear lista de productos");
            List<IProduct> listaProductos = new List<IProduct>();
            listaProductos.Add(creatorA.createProduct());
            listaProductos.Add(creatorA.createProduct());
            listaProductos.Add(creatorB.createProduct());
            listaProductos.Add(creatorB.createProduct());
            listaProductos.Add(creatorB.createProduct());
            listaProductos.Add(creatorC.createProduct());
            listaProductos.Add(creatorC.createProduct());

            foreach (IProduct product in listaProductos)
            {
                product.doStuff();  
                
            }

            Console.WriteLine("\n***Crear lista Creator***\n" );
            List<Creator> listaCreator = new List<Creator>();

            listaCreator.Add(new CreatorA());
            listaCreator.Add(new CreatorA());
            listaCreator.Add(new CreatorB());
            listaCreator.Add(new CreatorB());
            listaCreator.Add(new CreatorB());
            listaCreator.Add(new CreatorC());
            listaCreator.Add(new CreatorC());

            foreach (Creator creator in listaCreator)
            {
                creator.someOperacion();
            }



        }
    }
}