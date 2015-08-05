using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QLQuanCafe.Common
{
    public class BindableBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Sự kiện thông báo thay đổi property lên View
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Phương thức để chạy event PropertyChanged khi thay đổi property.
        /// </summary>
        /// <param name="propertyName">Tên của property</param>
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Phương thức dùng để gán giá trị cho property.
        /// </summary>
        /// <typeparam name="T">Kiểu của property</typeparam>
        /// <param name="storage">Biến lưu của property.</param>
        /// <param name="newValue">Giá trị mới sẽ gán cho property.</param>
        /// <param name="propertyChangedAction">Phương thức xử lý khi có sự thay đổi property.</param>
        /// <param name="propertyName">Phương</param>
        /// <returns>Trả về true nếu thay đối thành công. Ngược lại trả về false(giá trị mới và cũ như nhau).</returns>
        public bool SetProperty<T>(
            ref T storage,
            T newValue,
            Action<T> propertyChangedAction = null,
            [CallerMemberName]string propertyName = null)
        {
            // Nếu không có sự thay đổi giá trị.
            if (Equals(storage, newValue))
                return false;

            storage = newValue;

            OnPropertyChanged(propertyName);
            if (propertyChangedAction != null)
                propertyChangedAction(newValue);

            return true;
        }
    }
}
