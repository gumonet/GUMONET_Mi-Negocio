SELECT ap.id_producto, 
  ap.identificador,
  ap.nombre, 
  ap.descripcion,
  ap.unidad_medida,
   ap.n_parte,
  ap.id_categoria,
  ap.proveedor,
  ap.precio_compra, 
  ap.precio_venta,
  0 AS existencia, 
  ap.inventario_bajo,
  ap.iva, 
  ap.ieps,
  ap.imagen, 
  ac.nombre categoria,
  CONCAT_WS(' ',ap.identificador, ap.nombre) AS campo_buscar 
  FROM alm_productos ap,
  alm_categorias ac
  WHERE ap.tipo = 1
  AND ac.id_categoria = ap.id_categoria
  