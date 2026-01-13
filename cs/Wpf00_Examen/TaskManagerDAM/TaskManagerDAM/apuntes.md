
# Guía Técnica de Referencia: WPF y MVVM

## 1\. Implementación de Notificación de Cambios

Para actualizar la vista automáticamente desde el modelo, se debe implementar la interfaz `INotifyPropertyChanged`.

**Patrón de implementación:**

```csharp
public class Entidad : INotifyPropertyChanged
{
    private string _propiedad;

    public string Propiedad
    {
        get => _propiedad;
        set
        {
            if (_propiedad != value)
            {
                _propiedad = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
```

## 2\. Colecciones Dinámicas

Para listas que requieren actualización visual al añadir o eliminar elementos.

* **Clase requerida:** `ObservableCollection<T>`
* **Namespace:** `System.Collections.ObjectModel`

## 3\. Binding~~~~

**Modos de Binding (XAML):** 

* **Lectura (TextBlock):** `{Binding NombrePropiedad}`
* **Lectura/Escritura (TextBox, CheckBox):** `{Binding NombrePropiedad, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}`

## 4\. Patrón de Comandos (ICommand)

Para manejar eventos de botones desde el ViewModel.

**Enlace en XAML:**

```xml
<Button Command="{Binding NombreComando}" CommandParameter="{Binding .}" />
```

Para este examen, vas a necesitar usar ESTE boton, al que luego debes dar estilos:

```xml
<Button Content="Completar"
        Style=""
        Command="{Binding DataContext.IncluyeAquiTuCommand, RelativeSource={RelativeSource AncestorType=Window}}"
        CommandParameter="{Binding}"/>
```

IMPORTANTE: Sustituir IncluyeAquiTuCommand por el nombre de tu Command

## 5\. Personalización de Listas (DataTemplate)

Estructura para definir la visualización de objetos dentro de un `ItemsControl` o `ListBox`.

```xml
<ItemsControl ItemsSource="{Binding ListaDatos}">
    <ItemsControl.ItemTemplate>
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="{Binding Propiedad1}" />
                <Button Content="Acción" />
            </StackPanel>
        </DataTemplate>
    </ItemsControl.ItemTemplate>
</ItemsControl>
```

## 6\. Estilos y Triggers de Datos

Cambio de propiedades visuales basado en valores de datos.

```xml
<Style TargetType="TipoControl" x:Key="NombreEstilo">
    <Setter Property="Background" Value="Gray"/>
    
    <Style.Triggers>
        <DataTrigger Binding="{Binding PropiedadCondicion}" Value="ValorEsperado">
            <Setter Property="Background" Value="Red"/>
            <Setter Property="TextDecorations" Value="Strikethrough"/>
        </DataTrigger>
    </Style.Triggers>
</Style>
```