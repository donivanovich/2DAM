# Business Intelligence & Data Analytics (`powerbi`)

This directory contains business intelligence projects, dimensional data models, and interactive analytical dashboards built with **Microsoft Power BI Desktop** (`.pbix`). The coursework focuses on data transformation (ETL), relational and star-schema data modeling (Fact and Dimension tables), and visual KPI reporting across retail, media streaming, automotive, hospitality, healthcare, banking, logistics, and renewable energy datasets.

---

## Technologies and Tools

### Business Intelligence & Data Tools
- **Microsoft Power BI Desktop** (`.pbix`) — Data modeling, Power Query transformations, DAX calculations, and interactive report authoring.
- **Microsoft Excel** (`.xlsx`) — Structured multi-table workbooks and dimensional source files.
- **CSV Datasets** (`.csv`) — Daily transactional fact tables (3-year historical series) and master dimension tables used for star-schema modeling.

---

## Projects and Exercises

### 1. `00_Examen` (`VoltWear`)
- **Name:** `00_Examen` (`VoltWear`)
- **Description:** Practical examination project analyzing multi-country sales performance across sales channels and product lines for the fictional apparel/wearables brand **VoltWear**.
- **Technologies:** Microsoft Power BI Desktop (`.pbix`), Excel data sources (`.xlsx`).
- **Key Features:**
  - Integrates a central fact dataset (`VoltWear_Ventas.xlsx`) with four dimension workbooks: sales channels (`VoltWear_Canales.xlsx`), calendar dates (`VoltWear_Fechas.xlsx`), countries (`VoltWear_Paises.xlsx`), and products (`VoltWear_Productos.xlsx`).
  - Consolidates the data model and analytical visuals inside `VoltWear.pbix`.
- **Location:** [`./00_Examen`](./00_Examen)

### 2. `01_RetailModaSA`
- **Name:** `01_RetailModaSA`
- **Description:** Retail fashion sales and store performance dashboard built from the `Dataset_RetailModaSA.xlsx` dataset.
- **Technologies:** Microsoft Power BI Desktop (`.pbix`), Excel (`.xlsx`).
- **Key Features:**
  - Models retail fashion transactions and visualizes commercial metrics in `RetailModaSA.pbix`.
- **Location:** [`./01_RetailModaSA`](./01_RetailModaSA)

### 3. `02_StreamVibes`
- **Name:** `02_StreamVibes`
- **Description:** Digital streaming platform analytics report examining content consumption and subscriber metrics from `Dataset_StreamVibes.xlsx`.
- **Technologies:** Microsoft Power BI Desktop (`.pbix`), Excel (`.xlsx`).
- **Key Features:**
  - Imports and transforms streaming platform data from `Dataset_StreamVibes.xlsx` into interactive visual dashboards in `StreamVibes.pbix`.
- **Location:** [`./02_StreamVibes`](./02_StreamVibes)

### 4. `03_AppolDatos`
- **Name:** `03_AppolDatos`
- **Description:** Product and sales analysis report built from the modified `Appol+Datos_mod.xlsx` dataset.
- **Technologies:** Microsoft Power BI Desktop (`.pbix`), Excel (`.xlsx`).
- **Key Features:**
  - Cleanses and models the `Appol+Datos_mod.xlsx` workbook inside `AppolDatos.pbix`.
- **Location:** [`./03_AppolDatos`](./03_AppolDatos)

### 5. `04_Zaro`
- **Name:** `04_Zaro`
- **Description:** Multi-fact dimensional data model and executive sales vs. budget dashboard for the retail company **Zaro**.
- **Technologies:** Microsoft Power BI Desktop (`.pbix`), Excel (`.xlsx`).
- **Key Features:**
  - Implements a constellation / star-schema model combining two fact tables (`Zaro_Fact_Ventas.xlsx` and `Zaro_Fact_Presupuesto.xlsx`) with six dimension tables:
    - `Zaro_Dim_Canal.xlsx` (Sales Channels)
    - `Zaro_Dim_Cliente.xlsx` (Customers)
    - `Zaro_Dim_Fecha.xlsx` (Calendar Dimension)
    - `Zaro_Dim_Producto.xlsx` (Products)
    - `Zaro_Dim_Tienda.xlsx` (Stores)
    - `Zaro_Dim_Vendedor.xlsx` (Sales Representatives)
  - Compares actual sales performance against budget targets in `Zaro.pbix`.
- **Location:** [`./04_Zaro`](./04_Zaro)

### 6. `05_ModeloEnEstrella`
- **Name:** `05_ModeloEnEstrella`
- **Description:** Comprehensive Star-Schema dimensional modeling suite containing 10 domain-specific 3-year daily datasets (`.csv`) and a reference coffee sales Power BI report (`05_VentasCafe.pbix`).
- **Technologies:** Microsoft Power BI Desktop (`.pbix`), CSV flat files (`.csv`).
- **Key Features:**
  - Includes `05_VentasCafe.pbix` along with 10 multi-table CSV datasets designed for normalizing flat files and building star schemas:
    1. **CafeNebula (`01_cafenebula_*`):** Daily coffee sales over 3 years (`01_cafenebula_ventas_cafe_3y_daily.csv`).
    2. **NordCo (`02_nordco_*`):** Order headers and order lines (`pedido_cabecera_3y_daily.csv`, `pedido_linea_3y_daily.csv`).
    3. **CineLuz (`03_cineluz_*`):** Movie listings, cinemas, and daily ticket sales (`cartelera.csv`, `cines.csv`, `entradas_3y_daily.csv`).
    4. **AutoZen (`04_autozen_*`):** Automotive repair shop customers, mechanics, workshops, vehicles, work order headers, and service lines.
    5. **ViajaYa (`05_viajaya_*`):** Travel agency channels, customers, destinations, hotels, booking headers, and accommodation reservations.
    6. **StreamBee (`06_streambee_*`):** Streaming content, devices, subscription plans, users, user-plan assignments, and daily playback events.
    7. **SaludNova (`07_saludnova_*`):** Healthcare centers, doctors, medical specialties, patients, diagnostic tests, and 3-year daily appointments.
    8. **BancoFaro (`08_bancofaro_*`):** Banking channels, categories, customers, merchants, accounts, transaction types, and daily account movements.
    9. **ShipRocket (`09_shiprocket_*`):** Logistics cities, customers, shipment statuses, service tiers, carriers, and daily shipments.
    10. **SolarHorizon (`10_solarhorizon_*`):** Solar plant maintenance actions, equipment, incidents, power plants, severity levels, technicians, and daily work reports.
- **Location:** [`./05_ModeloEnEstrella`](./05_ModeloEnEstrella)

### 7. `06_Shawarmas`
- **Name:** `06_Shawarmas` (`ShawarmasBrand.pbix`)
- **Description:** Commercial analytics dashboard created for the **Shawarmas** brand project (aligned with the `Wpf10_Shawarmas` desktop application in `interfaces`).
- **Technologies:** Microsoft Power BI Desktop (`.pbix`).
- **Key Features:**
  - Provides brand and commercial performance visualizations in `ShawarmasBrand.pbix`.
- **Location:** [`./06_Shawarmas`](./06_Shawarmas)

---

## Additional Notes

> [!TIP]
> When opening any `.pbix` file in **Microsoft Power BI Desktop** after cloning the repository to a new machine, update the local file paths for the `.xlsx` or `.csv` data sources via **Transform data -> Data source settings** so Power Query can refresh the datasets from your local workspace directory.
