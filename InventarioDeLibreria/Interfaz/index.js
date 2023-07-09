const $botonProcesar = document.querySelector('#boton-procesar');
const resultado = document.querySelector('#resultado');

function mostrarCampos(){
    resultado.innerHTML = '';
    const inputProducto = document.createElement('input');
    const labelProducto = document.createElement('label');
    const inputCantidad = document.createElement('input');
    const labelCantidad = document.createElement('label');
    const botonAplicar = document.createElement('button');

    labelProducto.textContent = 'Producto: ';
    labelCantidad.textContent = 'Cantidad: ';
    botonAplicar.textContent = 'Aplicar transacción';

    resultado.appendChild(labelProducto);
    resultado.appendChild(inputProducto);
    resultado.appendChild(labelCantidad);
    resultado.appendChild(inputCantidad);
    resultado.appendChild(botonAplicar);
    //manejarClickAplicar(); // HAY QUE CREAR ESTA FUNCIÓN
}

$botonProcesar.onclick = function(){
    const valorSelect = document.querySelector('#opciones').value;
    if(valorSelect === "mostrar-stock"){
        resultado.innerHTML = '';
        //mostrarDatos();

    }
    else if(valorSelect === "comprar-a-proveedor"){
        resultado.innerHTML = '';
        mostrarCampos();

    }
    else if(valorSelect === "vender-producto"){
        resultado.innerHTML = '';
        mostrarCampos();

    }
}

/*function mostrarDatos(){
    //Conexión con archivos .cs

}*/

/*function actualizarDatos(){
    //Conexión con archivos .cs
    //Los cambios que hay que hacer en los atributos
    //mostrarDatos();
}*/