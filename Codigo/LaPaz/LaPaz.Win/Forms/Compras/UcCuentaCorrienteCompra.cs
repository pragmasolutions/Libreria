﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcCuentaCorrienteCompra : UserControlBase
    {
        
        public UcCuentaCorrienteCompra()
        {
            InitializeComponent();
        }

        public event EventHandler<decimal?> AnticipoChanged;
        public event EventHandler CuotasChanged;

        #region Propiedades
        public decimal? Anticipo
        {
            get
            {
                decimal anticipo;
                return decimal.TryParse(TxtAnticipo.Text, out anticipo) ? anticipo : (decimal?)null;
            }
            set
            {
                TxtAnticipo.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }

        public decimal? Adeuda
        {
            get
            {
                decimal adeuda;
                return decimal.TryParse(TxtAdeuda.Text, out adeuda) ? adeuda : (decimal?)null;
            }
            set
            {
                TxtAdeuda.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }

        public int? Cuotas
        {
            get
            {
                int cuotas;
                return int.TryParse(TxtCantidadCuotas.Text, out cuotas) ? cuotas : (int?)null;
            }
            set
            {
                TxtCantidadCuotas.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }

        public DateTime Vencimiento
        {
            get
            {
               // DateTime vencimiento;
                return DateTime.Parse(DTPVencimiento.Text);
                //vencimiento;
                //vencimiento;
                //true;
                //return DateTime.TryParse(DTPVencimiento.Text, out vencimiento) ? vencimiento : (DateTime?)null;
            }
            set
            {
                DTPVencimiento.Value = DateTime.Now.AddMonths(1);// value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }

        public float? Montocuota
        {
            get
            {
                float monto;
                return float.TryParse(TxtMontoCuota.Text, out monto) ? monto : (float?)null;
            }
            set
            {
                TxtMontoCuota.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }

        public decimal? SubTotal
        {
            get
            {
                decimal subtotal;
                return decimal.TryParse(TxtSubtotal.Text, out subtotal) ? subtotal : (decimal?)null;
            }
            set
            {
                TxtSubtotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }
        public decimal? Total
        {
            get
            {
                decimal total;
                return decimal.TryParse(TxtTotal.Text, out total) ? total : (decimal?)null;
            }
            set
            {
                TxtTotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                //TotalPagos();
            }
        }
        #endregion

        #region Eventos

        private void OnAnticipoChanged(decimal? monto)
        {
            if (AnticipoChanged != null)
            {
                AnticipoChanged(this, monto);
            }
        }

        private void OnCuotasChanged()
        {
            if (CuotasChanged != null)
            {
                CuotasChanged(this,null);
            }
        }

        #endregion

        public void ActualizarInfoCuentaCorriente(Cliente cliente)
        {
            
        }

        private void TxtAnticipo_TextChanged(object sender, EventArgs e)
        {
            if (Anticipo<= Adeuda )
                Adeuda = Total -Anticipo;
            if (Anticipo == 0 || Anticipo== null)
                Adeuda = Total;
           OnAnticipoChanged(Anticipo);
        }

        private void TxtCantidadCuotas_TextChanged(object sender, EventArgs e)
        {
            if (TxtCantidadCuotas.Text != "0"  && Adeuda != null && Cuotas != null)
            {
                Montocuota = (float)Adeuda / Cuotas;
                SubTotal = Cuotas * (decimal)Montocuota;
                OnCuotasChanged();
            }
        }

        private void TxtAdeuda_TextChanged(object sender, EventArgs e)
        {
            if (Adeuda != null & Cuotas != null)
            {
                Montocuota = (float)Adeuda / Cuotas;
                SubTotal = Cuotas * (decimal)Montocuota;
            }
            
        }

        private void DTPVencimiento_ValueChanged(object sender, EventArgs e)
        {
            if (DTPVencimiento.Value < DateTime.Now)
            {
                
                DTPVencimiento.Value = DateTime.Now;
            }
        }

        private void DTPVencimiento_Leave(object sender, EventArgs e)
        {
            if (DTPVencimiento.Value < DateTime.Now)
            {
                DTPVencimiento.Value = DateTime.Now;
            }
        }

        private void UcCuentaCorrienteCompra_Load(object sender, EventArgs e)
        {
            TxtCantidadCuotas.Text = "1";
        }
    }
}
