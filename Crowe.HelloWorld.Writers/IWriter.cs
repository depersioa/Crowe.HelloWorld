namespace Crowe.HelloWorld.Writers
{
    /// <summary>
    /// Inheritor is able to write message to specified destination
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Writes a message
        /// </summary>
        /// <param name="message">The message to write, for example "Hello World"</param>
        public void Write(string message) { }
    }
}
