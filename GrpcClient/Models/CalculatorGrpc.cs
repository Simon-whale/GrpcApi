// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Sums {
  public static partial class SumsService
  {
    static readonly string __ServiceName = "sums.SumsService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Sums.SumsRequest> __Marshaller_sums_SumsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sums.SumsRequest.Parser));
    static readonly grpc::Marshaller<global::Sums.SumsResponse> __Marshaller_sums_SumsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sums.SumsResponse.Parser));

    static readonly grpc::Method<global::Sums.SumsRequest, global::Sums.SumsResponse> __Method_Sums = new grpc::Method<global::Sums.SumsRequest, global::Sums.SumsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Sums",
        __Marshaller_sums_SumsRequest,
        __Marshaller_sums_SumsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sums.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SumsService</summary>
    [grpc::BindServiceMethod(typeof(SumsService), "BindService")]
    public abstract partial class SumsServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Sums.SumsResponse> Sums(global::Sums.SumsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SumsService</summary>
    public partial class SumsServiceClient : grpc::ClientBase<SumsServiceClient>
    {
      /// <summary>Creates a new client for SumsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SumsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SumsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SumsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SumsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SumsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Sums.SumsResponse Sums(global::Sums.SumsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Sums(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sums.SumsResponse Sums(global::Sums.SumsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Sums, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Sums.SumsResponse> SumsAsync(global::Sums.SumsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SumsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Sums.SumsResponse> SumsAsync(global::Sums.SumsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Sums, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SumsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SumsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SumsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Sums, serviceImpl.Sums).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SumsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Sums, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Sums.SumsRequest, global::Sums.SumsResponse>(serviceImpl.Sums));
    }

  }
}
#endregion
