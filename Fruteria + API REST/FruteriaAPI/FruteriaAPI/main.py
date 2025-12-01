from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
from typing import List

app = FastAPI()

# Modelo de datos
class Producto(BaseModel):
    id: int
    nombre: str
    categoria: str
    preciokg: float
    stockkg: float

class Venta(BaseModel):
    producto_id: int
    kilos: float

# Base de datos en memoria (lista) 
productos_db = [
    Producto(id=1, nombre="Manzana", categoria="Fruta", preciokg=2.5, stockkg=100),
    Producto(id=2, nombre="Pera", categoria="Fruta", preciokg=1.8, stockkg=50)
]
ventas_db = []

# --- ENDPOINTS DE PRODUCTOS ---

@app.get("/productos", response_model=List[Producto])
def listar_productos():
    return productos_db

@app.post("/productos")
def crear_producto(producto: Producto):
    productos_db.append(producto)
    return producto

@app.put("/productos/{id}")
def actualizar_producto(id: int, producto_actualizado: Producto):
    for index, p in enumerate(productos_db):
        if p.id == id:
            productos_db[index] = producto_actualizado
            return producto_actualizado
    raise HTTPException(status_code=404, detail="Producto no encontrado")

@app.delete("/productos/{id}")
def eliminar_producto(id: int):
    global productos_db
    productos_db = [p for p in productos_db if p.id != id]
    return {"mensaje": "Eliminado"}

# --- ENDPOINTS DE VENTAS ---

@app.post("/ventas")
def registrar_venta(venta: Venta):
    # Buscar producto y descontar stock
    for p in productos_db:
        if p.id == venta.producto_id:
            if p.stockkg >= venta.kilos:
                p.stockkg -= venta.kilos
                ventas_db.append(venta)
                return {"mensaje": "Venta registrada", "stock_restante": p.stockkg}
            else:
                raise HTTPException(status_code=400, detail="Stock insuficiente")
    raise HTTPException(status_code=404, detail="Producto no existe")

@app.get("/ventas")
def historial_ventas():
    return ventas_db

# Ejecución: python -m uvicorn main:app --reload