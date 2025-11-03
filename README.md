# 🧙‍♂️ Laberinto Mágico 2D

**Laberinto Mágico 2D** es un proyecto académico y personal desarrollado originalmente en **2017 (Imagen Campus)** y posteriormente actualizado a **Unity 2019** al realizar una migración entre equipos.  
El juego consiste en una experiencia **2D vista desde arriba**, donde el jugador controla a un **mago** que debe llegar del **punto A al punto B** evitando enemigos y obstáculos dentro de un laberinto.

---

## 🧩 Concepto del Juego

El objetivo principal es simple pero desafiante: **encontrar la salida del laberinto**.  
El jugador debe planificar sus movimientos cuidadosamente, ya que los enemigos patrullan rutas predefinidas y pueden detectar al mago si se aproxima demasiado.

---

## ⚙️ Aspectos Técnicos Destacados

- **Motor:** Unity (versión 2019, originalmente 2017)
- **Lenguaje:** C#
- **Género:** Aventura / Puzle / Top-Down 2D
- **Plataforma:** PC (prototipo jugable)
- **Tipo de proyecto:** Académico y experimental

### 🧠 Implementación del Sistema de Navegación

Uno de los mayores retos fue implementar un sistema de **pathfinding funcional en 2D**, ya que **Unity no contaba con soporte nativo para NavMesh en entornos 2D** en aquel entonces.

Para resolverlo, se aplicó una **solución alternativa creativa**:

- Se utilizó el **`NavMeshAgent`** (normalmente usado en 3D).  
- La **cámara se colocó en el eje Y con una inclinación de 90°**, simulando la vista cenital de un entorno 2D.  
- El entorno, colisiones y navegación se adaptaron para funcionar correctamente sobre el plano XZ.  

Esta estrategia permitió **usar navegación automática** y **evitación de obstáculos** en un entorno 2D, logrando una jugabilidad fluida sin necesidad de sistemas externos.

---

## 🎮 Mecánicas Principales

- Movimiento automático del jugador a la posición seleccionada.
- Detección y evasión de enemigos con IA básica.
- Colisiones y límites de escenario.
- Transición de niveles al llegar al destino.

---

## 🖼️ Capturas del Proyecto

_(Imágenes de libre licencia utilizadas con fines académicos)_

<div align="center">

<table>
  <tr>
    <td><img src="https://github.com/MiltonCastro93/Laberinto_Magico_2D-2019/blob/main/Captura%20de%20pantalla%202025-11-02%20143052.png" width="380"/></td>
    <td><img src="URL_IMAGEN_2" width="380"/></td>
  </tr>
</table>

</div>

---

## 🧾 Estado del Proyecto

- 📅 **Año original:** 2017  
- 🧭 **Actualizado a:** Unity 2019  
- 🧑‍💻 **Desarrollador:** Milton Castro  
- 🧪 **Propósito:** Académico y de experimentación técnica  

---

> 💡 *Este proyecto representa una solución técnica creativa para simular pathfinding en entornos 2D utilizando herramientas 3D, demostrando la flexibilidad del motor Unity y la adaptabilidad del desarrollador ante sus limitaciones técnicas.*

---
