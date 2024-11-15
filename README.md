# # Pizzeria
API para la generación de pizzas con delivery.

## End-points
### POST "/Pedidos/RealizarPedido"
Para poder realizar un pedido el end-point espera de un objecto con las siguientes propiedades, como ejemplo en un json:

    {
      "cliente": "string",
      "detalles": [
        {
          "pizzaNombre": "string",
          "ingredientes": [
            {
              "nombre": "string",
              "tipo": "string"
            }
          ],
          "cantidad": 0
        }
      ],
      "fechaPedido": "2024-11-15T21:09:28.659Z"
    }
Donde en algunas propiedades se debe tomar en cuenta:
|Propiedad|Observaciones  |
|--|--|
|pizzaNombre|El nombre de la pizza que solo acepta los siguientes valores: "Margarita", "Pepperoni", "CuatroQuesos" y "Personalizada"|
|ingredientes|Esta lista de ingredientes es solo requerido al solicitar una pizza "Personalizada", donde el "nombre" de los ingredientes pueden ser: "Salsa de tomate", "Queso", "Albahaca", "Tomate" y "Pepperoni" y para el "tipo" de los ingredientes solo es requerido para el "Queso" que pueden ser: "Mozzarella", "Parmesano", "Gorgonzola" y "Fontina"|
|fechaPedido|La fecha para cuando se realizará el pedido donde podrá contar con diferentes tipos de promociones, las cuales son: martes y miércoles, las pizzas 2x1; y el jueves, el delivery gratis.|

Un ejemplo del json que se puede utilizar es el siguiente:

    {
      "cliente": "Juan Perez",
      "detalles": [
        {
          "pizzaNombre": "Pepperoni",
          "ingredientes": null,
          "cantidad": 2
        },
        {
          "pizzaNombre": "Personalizada",
          "ingredientes": [
            {
              "nombre": "Salsa de Tomate",
              "tipo": null
            },
            {
              "nombre": "Queso",
              "tipo": "Fontina"
            },
            {
              "nombre": "Pepperoni",
              "tipo": null
            }
          ],
          "cantidad": 1
        }
      ],
      "fechaPedido": "2024-11-10T15:00:00.000Z"
    }
