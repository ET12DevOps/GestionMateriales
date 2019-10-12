using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionMateriales.Repository.Models
{
    public partial class OficinaTecnicaContext : DbContext
    {
        public OficinaTecnicaContext()
        {
        }

        public OficinaTecnicaContext(DbContextOptions<OficinaTecnicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entradamaterial> Entradamaterial { get; set; }
        public virtual DbSet<Itemordencompra> Itemordencompra { get; set; }
        public virtual DbSet<Itemordenpedido> Itemordenpedido { get; set; }
        public virtual DbSet<Itemordentrabajo> Itemordentrabajo { get; set; }
        public virtual DbSet<Itemordentrabajoaplicacion> Itemordentrabajoaplicacion { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Ordencompra> Ordencompra { get; set; }
        public virtual DbSet<Ordenpedido> Ordenpedido { get; set; }
        public virtual DbSet<Ordentrabajo> Ordentrabajo { get; set; }
        public virtual DbSet<Ordentrabajoaplicacion> Ordentrabajoaplicacion { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Salidamaterial> Salidamaterial { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Tipoentradamaterial> Tipoentradamaterial { get; set; }
        public virtual DbSet<Tipomaterial> Tipomaterial { get; set; }
        public virtual DbSet<Tipoordentrabajo> Tipoordentrabajo { get; set; }
        public virtual DbSet<Tiposalidamaterial> Tiposalidamaterial { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<Unidad> Unidad { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Entradamaterial>(entity =>
            {
                entity.HasKey(e => e.IdEntradaMaterial);

                entity.ToTable("entradamaterial", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdEntradaMaterial)
                    .HasName("idEntradaMaterial")
                    .IsUnique();

                entity.HasIndex(e => e.MaterialIdMaterial)
                    .HasName("material_idMaterial");

                entity.HasIndex(e => e.TipoEntradaMaterialIdTipoEntradaMaterial)
                    .HasName("tipoEntradaMaterial_idTipoEntradaMaterial");

                entity.Property(e => e.IdEntradaMaterial)
                    .HasColumnName("idEntradaMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoDocumento)
                    .IsRequired()
                    .HasColumnName("codigoDocumento")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMaterial)
                    .IsRequired()
                    .HasColumnName("codigoMaterial")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialIdMaterial)
                    .HasColumnName("material_idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoEntradaMaterialIdTipoEntradaMaterial)
                    .HasColumnName("tipoEntradaMaterial_idTipoEntradaMaterial")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MaterialIdMaterialNavigation)
                    .WithMany(p => p.Entradamaterial)
                    .HasForeignKey(d => d.MaterialIdMaterial)
                    .HasConstraintName("EntradaMaterial_material");

                entity.HasOne(d => d.TipoEntradaMaterialIdTipoEntradaMaterialNavigation)
                    .WithMany(p => p.Entradamaterial)
                    .HasForeignKey(d => d.TipoEntradaMaterialIdTipoEntradaMaterial)
                    .HasConstraintName("EntradaMaterial_tipoEntradaMaterial");
            });

            modelBuilder.Entity<Itemordencompra>(entity =>
            {
                entity.HasKey(e => e.IdItemOrdenCompra);

                entity.ToTable("itemordencompra", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdItemOrdenCompra)
                    .HasName("idItemOrdenCompra")
                    .IsUnique();

                entity.HasIndex(e => e.MaterialIdMaterial)
                    .HasName("material_idMaterial");

                entity.HasIndex(e => e.OrdenCompraIdOrdenCompra)
                    .HasName("ordenCompra_IdOrdenCompra");

                entity.Property(e => e.IdItemOrdenCompra)
                    .HasColumnName("idItemOrdenCompra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialIdMaterial)
                    .HasColumnName("material_idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenCompraIdOrdenCompra)
                    .HasColumnName("ordenCompra_IdOrdenCompra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrecioUnitario).HasColumnName("precioUnitario");

                entity.Property(e => e.Subtotal).HasColumnName("subtotal");

                entity.HasOne(d => d.MaterialIdMaterialNavigation)
                    .WithMany(p => p.Itemordencompra)
                    .HasForeignKey(d => d.MaterialIdMaterial)
                    .HasConstraintName("ItemOrdenCompra_material");

                entity.HasOne(d => d.OrdenCompraIdOrdenCompraNavigation)
                    .WithMany(p => p.Itemordencompra)
                    .HasForeignKey(d => d.OrdenCompraIdOrdenCompra)
                    .HasConstraintName("ItemOrdenCompra_ordenCompra");
            });

            modelBuilder.Entity<Itemordenpedido>(entity =>
            {
                entity.HasKey(e => e.IdItemOrdenPedido);

                entity.ToTable("itemordenpedido", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdItemOrdenPedido)
                    .HasName("idItemOrdenPedido")
                    .IsUnique();

                entity.HasIndex(e => e.MaterialIdMaterial)
                    .HasName("material_idMaterial");

                entity.HasIndex(e => e.OrdenPedidoIdOrdenPedido)
                    .HasName("ordenPedido_idOrdenPedido");

                entity.Property(e => e.IdItemOrdenPedido)
                    .HasColumnName("idItemOrdenPedido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaterialIdMaterial)
                    .HasColumnName("material_idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenPedidoIdOrdenPedido)
                    .HasColumnName("ordenPedido_idOrdenPedido")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MaterialIdMaterialNavigation)
                    .WithMany(p => p.Itemordenpedido)
                    .HasForeignKey(d => d.MaterialIdMaterial)
                    .HasConstraintName("ItemOrdenPedido_material");

                entity.HasOne(d => d.OrdenPedidoIdOrdenPedidoNavigation)
                    .WithMany(p => p.Itemordenpedido)
                    .HasForeignKey(d => d.OrdenPedidoIdOrdenPedido)
                    .HasConstraintName("ItemOrdenPedido_ordenPedido");
            });

            modelBuilder.Entity<Itemordentrabajo>(entity =>
            {
                entity.HasKey(e => e.IdItemOrdenTrabajo);

                entity.ToTable("itemordentrabajo", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdItemOrdenTrabajo)
                    .HasName("idItemOrdenTrabajo")
                    .IsUnique();

                entity.HasIndex(e => e.MaterialIdMaterial)
                    .HasName("material_idMaterial");

                entity.HasIndex(e => e.OrdenTrabajoIdOrdenTrabajo)
                    .HasName("ordenTrabajo_idOrdenTrabajo");

                entity.Property(e => e.IdItemOrdenTrabajo)
                    .HasColumnName("idItemOrdenTrabajo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaRetiro).HasColumnName("fechaRetiro");

                entity.Property(e => e.MaterialIdMaterial)
                    .HasColumnName("material_idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenTrabajoIdOrdenTrabajo)
                    .HasColumnName("ordenTrabajo_idOrdenTrabajo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MaterialIdMaterialNavigation)
                    .WithMany(p => p.Itemordentrabajo)
                    .HasForeignKey(d => d.MaterialIdMaterial)
                    .HasConstraintName("ItemOrdenTrabajo_material");

                entity.HasOne(d => d.OrdenTrabajoIdOrdenTrabajoNavigation)
                    .WithMany(p => p.Itemordentrabajo)
                    .HasForeignKey(d => d.OrdenTrabajoIdOrdenTrabajo)
                    .HasConstraintName("ItemOrdenTrabajo_ordenTrabajo");
            });

            modelBuilder.Entity<Itemordentrabajoaplicacion>(entity =>
            {
                entity.HasKey(e => e.IdItemOrdenTrabajoAplicacion);

                entity.ToTable("itemordentrabajoaplicacion", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdItemOrdenTrabajoAplicacion)
                    .HasName("idItemOrdenTrabajoAplicacion")
                    .IsUnique();

                entity.HasIndex(e => e.MaterialIdMaterial)
                    .HasName("material_idMaterial");

                entity.HasIndex(e => e.OrdenTrabajoAplicacionIdOrdenTrabajoAplicacion)
                    .HasName("ordenTrabajoAplicacion_idOrdenTrabajoAplicacion");

                entity.Property(e => e.IdItemOrdenTrabajoAplicacion)
                    .HasColumnName("idItemOrdenTrabajoAplicacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasColumnName("destino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialIdMaterial)
                    .HasColumnName("material_idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenTrabajoAplicacionIdOrdenTrabajoAplicacion)
                    .HasColumnName("ordenTrabajoAplicacion_idOrdenTrabajoAplicacion")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MaterialIdMaterialNavigation)
                    .WithMany(p => p.Itemordentrabajoaplicacion)
                    .HasForeignKey(d => d.MaterialIdMaterial)
                    .HasConstraintName("ItemOrdenTrabajoAplicacion_material");

                entity.HasOne(d => d.OrdenTrabajoAplicacionIdOrdenTrabajoAplicacionNavigation)
                    .WithMany(p => p.Itemordentrabajoaplicacion)
                    .HasForeignKey(d => d.OrdenTrabajoAplicacionIdOrdenTrabajoAplicacion)
                    .HasConstraintName("ItemOrdenTrabajoAplicacion_ordenTrabajoAplicacion");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.IdMaterial);

                entity.ToTable("material", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdMaterial)
                    .HasName("idMaterial")
                    .IsUnique();

                entity.HasIndex(e => e.ProveedorIdProveedor)
                    .HasName("proveedor_idProveedor");

                entity.HasIndex(e => e.TipoMaterialIdTipoMaterial)
                    .HasName("tipoMaterial_idTipoMaterial");

                entity.HasIndex(e => e.UnidadIdUnidad)
                    .HasName("unidad_idUnidad");

                entity.Property(e => e.IdMaterial)
                    .HasColumnName("idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorIdProveedor)
                    .HasColumnName("proveedor_idProveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockActual)
                    .HasColumnName("stockActual")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockMinimo)
                    .HasColumnName("stockMinimo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoMaterialIdTipoMaterial)
                    .HasColumnName("tipoMaterial_idTipoMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnidadIdUnidad)
                    .HasColumnName("unidad_idUnidad")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ProveedorIdProveedorNavigation)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.ProveedorIdProveedor)
                    .HasConstraintName("Material_proveedor");

                entity.HasOne(d => d.TipoMaterialIdTipoMaterialNavigation)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.TipoMaterialIdTipoMaterial)
                    .HasConstraintName("Material_tipoMaterial");

                entity.HasOne(d => d.UnidadIdUnidadNavigation)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.UnidadIdUnidad)
                    .HasConstraintName("Material_unidad");
            });

            modelBuilder.Entity<Ordencompra>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompra);

                entity.ToTable("ordencompra", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdOrdenCompra)
                    .HasName("IdOrdenCompra")
                    .IsUnique();

                entity.HasIndex(e => e.ProveedorIdProveedor)
                    .HasName("proveedor_idProveedor");

                entity.HasIndex(e => e.ResponsableIdPersonal)
                    .HasName("responsable_idPersonal");

                entity.Property(e => e.IdOrdenCompra).HasColumnType("int(11)");

                entity.Property(e => e.ChequeNro)
                    .IsRequired()
                    .HasColumnName("chequeNro")
                    .HasColumnType("longtext");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .IsRequired()
                    .HasColumnName("numeroFactura")
                    .HasColumnType("longtext");

                entity.Property(e => e.NumeroInterno)
                    .HasColumnName("numeroInterno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProveedorIdProveedor)
                    .HasColumnName("proveedor_idProveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponsableIdPersonal)
                    .HasColumnName("responsable_idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.ProveedorIdProveedorNavigation)
                    .WithMany(p => p.Ordencompra)
                    .HasForeignKey(d => d.ProveedorIdProveedor)
                    .HasConstraintName("OrdenCompra_proveedor");

                entity.HasOne(d => d.ResponsableIdPersonalNavigation)
                    .WithMany(p => p.Ordencompra)
                    .HasForeignKey(d => d.ResponsableIdPersonal)
                    .HasConstraintName("OrdenCompra_responsable");
            });

            modelBuilder.Entity<Ordenpedido>(entity =>
            {
                entity.HasKey(e => e.IdOrdenPedido);

                entity.ToTable("ordenpedido", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdOrdenPedido)
                    .HasName("idOrdenPedido")
                    .IsUnique();

                entity.Property(e => e.IdOrdenPedido)
                    .HasColumnName("idOrdenPedido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasColumnName("destino")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroOrdenPedido)
                    .HasColumnName("numeroOrdenPedido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroOrdenTrabajoAplicacion)
                    .HasColumnName("numeroOrdenTrabajoAplicacion")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ordentrabajo>(entity =>
            {
                entity.HasKey(e => e.IdOrdenTrabajo);

                entity.ToTable("ordentrabajo", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdOrdenTrabajo)
                    .HasName("idOrdenTrabajo")
                    .IsUnique();

                entity.HasIndex(e => e.JefeSeccionIdPersonal)
                    .HasName("jefeSeccion_idPersonal");

                entity.HasIndex(e => e.SolicitanteIdPersonal)
                    .HasName("solicitante_idPersonal");

                entity.HasIndex(e => e.TipoOrdenTrabajoIdTipoOrdenTrabajo)
                    .HasName("tipoOrdenTrabajo_idTipoOrdenTrabajo");

                entity.Property(e => e.IdOrdenTrabajo)
                    .HasColumnName("idOrdenTrabajo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTarea)
                    .IsRequired()
                    .HasColumnName("descripcionTarea")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasColumnName("destino")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Encabezado)
                    .IsRequired()
                    .HasColumnName("encabezado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.FechaIngresoDeposito).HasColumnName("fechaIngresoDeposito");

                entity.Property(e => e.FechaTerminada).HasColumnName("fechaTerminada");

                entity.Property(e => e.Fechainiciada).HasColumnName("fechainiciada");

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.JefeSeccionIdPersonal)
                    .HasColumnName("jefeSeccion_idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SolicitanteIdPersonal)
                    .HasColumnName("solicitante_idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoOrdenTrabajoIdTipoOrdenTrabajo)
                    .HasColumnName("tipoOrdenTrabajo_idTipoOrdenTrabajo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.JefeSeccionIdPersonalNavigation)
                    .WithMany(p => p.OrdentrabajoJefeSeccionIdPersonalNavigation)
                    .HasForeignKey(d => d.JefeSeccionIdPersonal)
                    .HasConstraintName("OrdenTrabajo_jefeSeccion");

                entity.HasOne(d => d.SolicitanteIdPersonalNavigation)
                    .WithMany(p => p.OrdentrabajoSolicitanteIdPersonalNavigation)
                    .HasForeignKey(d => d.SolicitanteIdPersonal)
                    .HasConstraintName("OrdenTrabajo_solicitante");

                entity.HasOne(d => d.TipoOrdenTrabajoIdTipoOrdenTrabajoNavigation)
                    .WithMany(p => p.Ordentrabajo)
                    .HasForeignKey(d => d.TipoOrdenTrabajoIdTipoOrdenTrabajo)
                    .HasConstraintName("OrdenTrabajo_tipoOrdenTrabajo");
            });

            modelBuilder.Entity<Ordentrabajoaplicacion>(entity =>
            {
                entity.HasKey(e => e.IdOrdenTrabajoAplicacion);

                entity.ToTable("ordentrabajoaplicacion", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdOrdenTrabajoAplicacion)
                    .HasName("idOrdenTrabajoAplicacion")
                    .IsUnique();

                entity.HasIndex(e => e.IdTurno)
                    .HasName("idTurno");

                entity.HasIndex(e => e.JefeSeccionIdPersonal)
                    .HasName("jefeSeccion_idPersonal");

                entity.HasIndex(e => e.ResponsableIdPersonal)
                    .HasName("responsable_idPersonal");

                entity.Property(e => e.IdOrdenTrabajoAplicacion)
                    .HasColumnName("idOrdenTrabajoAplicacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IdTurno)
                    .HasColumnName("idTurno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JefeSeccionIdPersonal)
                    .HasColumnName("jefeSeccion_idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponsableIdPersonal)
                    .HasColumnName("responsable_idPersonal")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdTurnoNavigation)
                    .WithMany(p => p.Ordentrabajoaplicacion)
                    .HasForeignKey(d => d.IdTurno)
                    .HasConstraintName("OrdenTrabajoAplicacion_turno");

                entity.HasOne(d => d.JefeSeccionIdPersonalNavigation)
                    .WithMany(p => p.OrdentrabajoaplicacionJefeSeccionIdPersonalNavigation)
                    .HasForeignKey(d => d.JefeSeccionIdPersonal)
                    .HasConstraintName("OrdenTrabajoAplicacion_jefeSeccion");

                entity.HasOne(d => d.ResponsableIdPersonalNavigation)
                    .WithMany(p => p.OrdentrabajoaplicacionResponsableIdPersonalNavigation)
                    .HasForeignKey(d => d.ResponsableIdPersonal)
                    .HasConstraintName("OrdenTrabajoAplicacion_responsable");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.IdPersonal);

                entity.ToTable("personal", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdPersonal)
                    .HasName("idPersonal")
                    .IsUnique();

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FichaCensal)
                    .HasColumnName("fichaCensal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("proveedor", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("idProveedor")
                    .IsUnique();

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("idProveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .IsRequired()
                    .HasColumnName("cuit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hab)
                    .HasColumnName("hab")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Horario)
                    .IsRequired()
                    .HasColumnName("horario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContacto)
                    .IsRequired()
                    .HasColumnName("nombreContacto")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("razonSocial")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .IsRequired()
                    .HasColumnName("zona")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salidamaterial>(entity =>
            {
                entity.HasKey(e => e.IdSalidaMaterial);

                entity.ToTable("salidamaterial", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdSalidaMaterial)
                    .HasName("idSalidaMaterial")
                    .IsUnique();

                entity.HasIndex(e => e.MaterialIdMaterial)
                    .HasName("material_idMaterial");

                entity.HasIndex(e => e.TipoSalidaMaterialIdTipoSalidaMaterial)
                    .HasName("tipoSalidaMaterial_idTipoSalidaMaterial");

                entity.Property(e => e.IdSalidaMaterial)
                    .HasColumnName("idSalidaMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoDocumento)
                    .IsRequired()
                    .HasColumnName("codigoDocumento")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMaterial)
                    .IsRequired()
                    .HasColumnName("codigoMaterial")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("longtext");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreationIp)
                    .HasColumnName("CREATION_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnName("LAST_UPDATED_DATE");

                entity.Property(e => e.LastUpdatedIp)
                    .HasColumnName("LAST_UPDATED_IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialIdMaterial)
                    .HasColumnName("material_idMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoSalidaMaterialIdTipoSalidaMaterial)
                    .HasColumnName("tipoSalidaMaterial_idTipoSalidaMaterial")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MaterialIdMaterialNavigation)
                    .WithMany(p => p.Salidamaterial)
                    .HasForeignKey(d => d.MaterialIdMaterial)
                    .HasConstraintName("SalidaMaterial_material");

                entity.HasOne(d => d.TipoSalidaMaterialIdTipoSalidaMaterialNavigation)
                    .WithMany(p => p.Salidamaterial)
                    .HasForeignKey(d => d.TipoSalidaMaterialIdTipoSalidaMaterial)
                    .HasConstraintName("SalidaMaterial_tipoSalidaMaterial");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.IdSector);

                entity.ToTable("sector", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdSector)
                    .HasName("idSector")
                    .IsUnique();

                entity.Property(e => e.IdSector)
                    .HasColumnName("idSector")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipoentradamaterial>(entity =>
            {
                entity.HasKey(e => e.IdTipoEntradaMaterial);

                entity.ToTable("tipoentradamaterial", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdTipoEntradaMaterial)
                    .HasName("idTipoEntradaMaterial")
                    .IsUnique();

                entity.HasIndex(e => e.SectorIdSector)
                    .HasName("sector_idSector");

                entity.Property(e => e.IdTipoEntradaMaterial)
                    .HasColumnName("idTipoEntradaMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdSector)
                    .HasColumnName("sector_idSector")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SectorIdSectorNavigation)
                    .WithMany(p => p.Tipoentradamaterial)
                    .HasForeignKey(d => d.SectorIdSector)
                    .HasConstraintName("TipoEntradaMaterial_sector");
            });

            modelBuilder.Entity<Tipomaterial>(entity =>
            {
                entity.HasKey(e => e.IdTipoMaterial);

                entity.ToTable("tipomaterial", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdTipoMaterial)
                    .HasName("idTipoMaterial")
                    .IsUnique();

                entity.Property(e => e.IdTipoMaterial)
                    .HasColumnName("idTipoMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipoordentrabajo>(entity =>
            {
                entity.HasKey(e => e.IdTipoOrdenTrabajo);

                entity.ToTable("tipoordentrabajo", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdTipoOrdenTrabajo)
                    .HasName("idTipoOrdenTrabajo")
                    .IsUnique();

                entity.Property(e => e.IdTipoOrdenTrabajo)
                    .HasColumnName("idTipoOrdenTrabajo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tiposalidamaterial>(entity =>
            {
                entity.HasKey(e => e.IdTipoSalidaMaterial);

                entity.ToTable("tiposalidamaterial", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdTipoSalidaMaterial)
                    .HasName("idTipoSalidaMaterial")
                    .IsUnique();

                entity.HasIndex(e => e.SectorIdSector)
                    .HasName("sector_idSector");

                entity.Property(e => e.IdTipoSalidaMaterial)
                    .HasColumnName("idTipoSalidaMaterial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SectorIdSector)
                    .HasColumnName("sector_idSector")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SectorIdSectorNavigation)
                    .WithMany(p => p.Tiposalidamaterial)
                    .HasForeignKey(d => d.SectorIdSector)
                    .HasConstraintName("TipoSalidaMaterial_sector");
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.IdTurno);

                entity.ToTable("turno", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdTurno)
                    .HasName("idTurno")
                    .IsUnique();

                entity.Property(e => e.IdTurno)
                    .HasColumnName("idTurno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unidad>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.ToTable("unidad", "sgm_oficinatecnica");

                entity.HasIndex(e => e.IdUnidad)
                    .HasName("idUnidad")
                    .IsUnique();

                entity.Property(e => e.IdUnidad)
                    .HasColumnName("idUnidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });
        }
    }
}
