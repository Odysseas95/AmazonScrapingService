using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
    /// <summary>
    /// Provides factory methods to create <see cref="AsyncLazy{T}"/> instances with type inference.
    /// Enables creation of async lazy objects without explicit type specification.
    /// </summary>
    static partial class AsyncLazy
    {
        /// <summary>
        /// Creates an <see cref="AsyncLazy{T}"/> using a synchronous value factory.
        /// </summary>
        public static AsyncLazy<T> Create<T>(Func<T> valueFactory) => new AsyncLazy<T>(valueFactory);

        /// <summary>
        /// Creates an <see cref="AsyncLazy{T}"/> using an asynchronous value factory.
        /// </summary>
     public static AsyncLazy<T> Create<T>(Func<Task<T>> asyncValueFactory) => new AsyncLazy<T>(asyncValueFactory);
    }

    /// <summary>
    /// An asynchronous version of <see cref="Lazy{T}"/> that enables awaitable lazy initialization.
    /// </summary>
    public partial class AsyncLazy<T> : Lazy<Task<T>>
    {
        /// <summary>
        /// Initializes AsyncLazy with a synchronous value factory.
        /// </summary>
        public AsyncLazy(Func<T> valueFactory) : base(() => Task.Run(valueFactory))
        { }

        /// <summary>
        /// Initializes AsyncLazy with an asynchronous value factory.
  /// </summary>
        public AsyncLazy(Func<Task<T>> asyncValueFactory) : base(() => Task.Run(() => asyncValueFactory()))
        { }

        /// <summary>
        /// Enables direct awaiting of the AsyncLazy instance.
        /// </summary>
   public TaskAwaiter<T> GetAwaiter() => Value.GetAwaiter();
    
        /// <summary>
        /// Gets whether the value factory has completed execution successfully.
        /// </summary>
 public bool IsValueFactoryCompleted => base.Value.IsCompleted;        
    }
}